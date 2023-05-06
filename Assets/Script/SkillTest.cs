using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTest : MonoBehaviour
{
    [SerializeField]
    private List<SkillTest> _nextSkills;
    [SerializeField]
    private Button[] _button;

    // n�Ԃ�Button�������邩�ǂ���true/false
    Dictionary<int, bool> _dic = new Dictionary<int, bool>(3);

    // 1,2,3
    List<int>[] _skillList;

    void Awake()
    {
        for(int i = 0; i < 3; i++)
        {
            _dic.Add(i, false);
        }

        for(int i = 1; i < _button.Length; i++)
        {
            _button[i].interactable = false;
        }

        _skillList = new List<int>[4];
        for(int i = 0; i < _skillList.Length; i++)
        {
            _skillList[i] = new List<int>();
        }
        _skillList[1].Add(1);
        _skillList[1].Add(2);
    }

    void Update()
    {
        for(int i = 1; i < _button.Length; i++)
        {
            bool isOk = _dic[i];
            _button[i].interactable = isOk;
        }
    }

    public void Test()
    {

    }

    public void OnPush(int index)
    {
        List<int> next = _skillList[index];
        foreach(int i in next)
        {
            _dic[i] = true;
        }
        Debug.Log("�X�L��1���Ƃ������ɂƂ��悤�ɂȂ�X�L��" + _skillList[1][0]);
        Debug.Log("�X�L��1���Ƃ������ɂƂ��悤�ɂȂ�X�L��" + _skillList[1][1]);
    }
}

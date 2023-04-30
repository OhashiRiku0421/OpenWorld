using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTree : MonoBehaviour
{

    [SerializeField]
    private Button[] _buttons;

    private List<int>[] _skillList;//�אڃ��X�g

    private Dictionary<int, bool> _dic = new Dictionary<int, bool>();

    private void Awake()
    {
        _skillList = new List<int>[_buttons.Length];

        for (int i = 0; i < _buttons.Length; i++)
        {
            _dic.Add(i, false);
            _buttons[i].interactable = _dic[i];
            _skillList[i] = new List<int>(); // �e���_�ɋ�̗אڃ��X�g��������
        }

        //0�Ԗڂ����ŏ�����J���ł���悤�ɂ���
        _buttons[0].interactable = true;
    }

    private void Start()
    {
        //���_�Ǝq�̒��_���w��
        AddEdge(0, "1 2 3 4");
        AddEdge(1, "5 6");
        AddEdge(2, "7 8");
        AddEdge(3, "9 10");
        AddEdge(4, "11 12");
        DebugTest();
    }

    /// <summary>
    /// �X�L�����J�����Ďq�̃X�L�����J���ł���悤�ɂ���
    /// </summary>
    public void OnPush(int index)
    {

        foreach (int n in _skillList[index])
        {
            _dic[n] = true;
            _buttons[n].interactable = _dic[n];
        }
    }

    /// <summary>
    /// ���_�̗אڃ��X�g�Ɏq�̒��_��ǉ�����
    /// </summary>
    private void AddEdge(int edge, string childEdge)
    {
        var array = childEdge.Split();//����
        foreach(string c in array)
        {
            _skillList[edge].Add(int.Parse(c));///int�ɃL���X�g���Ēǉ�
        }
        
    }

    private void DebugTest()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"���_{i}: ");
            foreach (int j in _skillList[i])
            {
                Debug.Log(j);
            }
        }
    }
}
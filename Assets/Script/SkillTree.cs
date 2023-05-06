using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTree : MonoBehaviour
{

    [SerializeField]
    private Button[] _buttons;

    [SerializeField]
    private GameObject[] _panels;

    private List<int>[] _skillList;//隣接リスト

    private Dictionary<int, bool> _dic = new Dictionary<int, bool>();

    private void Awake()
    {
        _skillList = new List<int>[_buttons.Length];

        for (int i = 0; i < _buttons.Length; i++)
        {
            _dic.Add(i, false);
            _buttons[i].interactable = _dic[i];
            _skillList[i] = new List<int>(); // 各頂点に空の隣接リストを初期化
        }

        //0番目だけ最初から開放できるようにする
        _buttons[0].interactable = true;
    }

    private void Start()
    {
        //頂点と子の頂点を指定
        AddEdge(0, "1 2 3 4");
        AddEdge(1, "5 6");
        AddEdge(2, "7 8");
        AddEdge(3, "9 10");
        AddEdge(4, "11 12");
        DebugTest();
    }

    /// <summary>
    /// スキルを開放して子のスキルを開放できるようにする
    /// </summary>
    public void OnPush(int index)
    {

        foreach (int n in _skillList[index])
        {
            _dic[n] = true;
            _buttons[n].interactable = _dic[n];
        }
        _panels[index].SetActive(true);
    }

    /// <summary>
    /// 頂点の隣接リストに子の頂点を追加する
    /// </summary>
    private void AddEdge(int edge, string childEdge)
    {
        var array = childEdge.Split();//分割
        foreach(string c in array)
        {
            _skillList[edge].Add(int.Parse(c));///intにキャストして追加
        }
        
    }

    private void DebugTest()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"頂点{i}: ");
            foreach (int j in _skillList[i])
            {
                Debug.Log(j);
            }
        }
    }
}
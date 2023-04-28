using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTree : MonoBehaviour
{

    [SerializeField]
    private SkillNode[] _chilled;

    private List<SkillNode>[] _skillTrees;

    private void Awake()
    {
        foreach(var node in _chilled)
        {
            node.ButtonInit();
        }

        SetChilled(0, _chilled);
    }

    private void SetChilled(int chilledNum, SkillNode[] nodes)
    {
        for (int i = 0; i < nodes.Length; i++)
        {
            _skillTrees[chilledNum].Add(_chilled[i]);
        }
    }
}

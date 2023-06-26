using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "TalkData")]

public class TalkData : ScriptableObject
{
    [Header("�b������̖��O")]
    [SerializeField] private string _humanName;

    [Header("�b�����e")]
    [SerializeField] private List<string> _talkData = new List<string>();

    public string HumanName => _humanName;

    public List<string> DataTalk => _talkData;

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusView : MonoBehaviour
{
    [SerializeField]
    private Text _pointText;

    [SerializeField]
    private Text _levelText;

    public void SkillPointText(int point)
    {
        _pointText.text = point.ToString();
    }

    public void LevelText(int level)
    {
        _levelText.text = level.ToString();
    }
}

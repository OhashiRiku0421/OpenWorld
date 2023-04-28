using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillNode : MonoBehaviour
{
    private Button _button;

    private void Start()
    {
        _button.GetComponent<Button>();
    }
    private void Update()
    {
        
    }
    public void ButtonInit()
    {
        _button.interactable = false;
    }
}

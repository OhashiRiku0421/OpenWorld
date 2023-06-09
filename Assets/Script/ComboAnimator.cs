using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboAnimator : StateMachineBehaviour
{
    [SerializeField]
    private string _triggerName;

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger(_triggerName);
    }
}

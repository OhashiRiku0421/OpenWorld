using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Skill
{
    [Serializable]
    public class Skill2 : ISkillable
    {
        public void OnSkill()
        {
            Debug.Log("Skill2�J��");
        }
    }
}



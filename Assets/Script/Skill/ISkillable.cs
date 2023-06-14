using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Skill
{
    public interface ISkillable
    {
        /// <summary>
        /// Buttonが押されたときのスキルの開放
        /// </summary>
        /// <returns>スキルを開放できるかできないか</returns>
        public bool OnSkill();
    }
}


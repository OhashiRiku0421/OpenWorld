using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Skill
{
    public interface ISkillable
    {
        /// <summary>
        /// Button�������ꂽ�Ƃ��̃X�L���̊J��
        /// </summary>
        /// <returns>�X�L�����J���ł��邩�ł��Ȃ���</returns>
        public bool OnSkill();
    }
}


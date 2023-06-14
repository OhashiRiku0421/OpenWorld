using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Skill
{
    [Serializable]
    public class Skill : ISkillable
    {

        [SerializeField]
        private int _skillPoint;

        [SerializeField]
        private PlayerController _playerController;

        public bool OnSkill()
        {
            if (_playerController.PlayerStatus.TestSkillPoint >= _skillPoint)
            {
                _playerController.PlayerStatus.TestSkillPoint -= _skillPoint;
                Debug.Log("�X�L���J���ɐ������܂����B");
                return true;
            }

            Debug.Log("�X�L���J���Ɏ��s���܂����B");
            return false;
        }
    }
}



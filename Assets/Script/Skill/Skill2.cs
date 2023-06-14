using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Skill
{

    [Serializable]
    public class Skill2 : ISkillable
    {

        [SerializeField, Tooltip("�X�L���̊J���ɕK�v�ȃX�L���|�C���g")]
        private int _skillPoint;

        [SerializeField]
        private PlayerController _playerController;

        public bool OnSkill()
        {
            if (_playerController.PlayerStatus.TestSkillPoint >= _skillPoint)
            {
                _playerController.PlayerStatus.TestSkillPoint -= _skillPoint;
                Debug.Log("�X�L��2�̊J���ɐ������܂����B");
                return true;
            }

            Debug.Log("�X�L��2�̊J���Ɏ��s���܂����B");
            return false;

        }
    }
}



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

        [SerializeField]
        private GameObject _sword;

        private void SwordSkill()
        {
            _playerController.Swords.Add(_sword);
        }
        public bool OnSkill()
        {
            if (_playerController.PlayerStatus.SkillPoint.Value >= _skillPoint)
            {
                _playerController.PlayerStatus.SkillPoint.Value -= _skillPoint;
                SwordSkill();
                Debug.Log("�X�L��2�̊J���ɐ������܂����B");
                return true;
            }

            Debug.Log("�X�L��2�̊J���Ɏ��s���܂����B");
            return false;

        }
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Skill
{

    [Serializable]
    public class Skill2 : ISkillable
    {

        [SerializeField, Tooltip("スキルの開放に必要なスキルポイント")]
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
                Debug.Log("スキル2の開放に成功しました。");
                return true;
            }

            Debug.Log("スキル2の開放に失敗しました。");
            return false;

        }
    }
}



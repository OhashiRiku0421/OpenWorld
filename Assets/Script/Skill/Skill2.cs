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

        public bool OnSkill()
        {
            if (_playerController.PlayerStatus.TestSkillPoint >= _skillPoint)
            {
                _playerController.PlayerStatus.TestSkillPoint -= _skillPoint;
                Debug.Log("スキル2の開放に成功しました。");
                return true;
            }

            Debug.Log("スキル2の開放に失敗しました。");
            return false;

        }
    }
}



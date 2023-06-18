using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Cysharp.Threading.Tasks;

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
            if (_playerController.PlayerStatus.SkillPoint.Value >= _skillPoint)
            {
                _playerController.PlayerStatus.SkillPoint.Value -= _skillPoint;
                _playerController.IsSkill = true;
                Debug.Log("スキル開放に成功しました。");
                return true;
            }

            Debug.Log("スキル開放に失敗しました。");
            return false;
        }
    }
}



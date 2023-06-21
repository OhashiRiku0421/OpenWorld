using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class StatusPresenter : MonoBehaviour
{
    [SerializeField]
    private PlayerController _player;

    [SerializeField]
    private StatusView _statusView;
    void Start()
    {
        _player.PlayerStatus.SkillPoint.Subscribe(n => _statusView.SkillPointText(n));
        _player.PlayerStatus.Level.Subscribe(n => _statusView.LevelText(n));
    }
}

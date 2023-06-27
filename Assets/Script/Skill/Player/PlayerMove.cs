using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PlayerMove
{
    [SerializeField]
    private float _moveSpeed = 5f;

    [SerializeField]
    private float _turn = 10;

    private Quaternion _targetRotation;

    //private Vector3 _dir;

    private Transform _transform;

    private Rigidbody _rb;

    private Animator _animator;

    public void Initialize(Animator animator, Transform transform, Rigidbody rb)
    {
        _targetRotation = transform.rotation;
        _transform = transform;
        _rb = rb;
        _animator = animator;
    }

    public void Move(Vector3 dir)
    {
        //playerのワールド座標をメインカメラのローカル座標に変換する。
        dir = Camera.main.transform.TransformDirection(dir);
        dir.y = 0;
        _animator.SetFloat("Move", dir.magnitude, 0.1f, Time.deltaTime);
        //入力していたら
        if (dir.magnitude > 0.5f)
        {
            //ターンの処理
            _targetRotation = Quaternion.LookRotation(dir, Vector3.up);
            _transform.rotation = Quaternion.RotateTowards(_transform.rotation, _targetRotation, _turn);
        }
        _rb.velocity = dir * _moveSpeed + new Vector3(0f, _rb.velocity.y, 0f);
    }
}

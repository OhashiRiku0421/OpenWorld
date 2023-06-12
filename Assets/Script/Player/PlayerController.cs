using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 5f;

    private Rigidbody _rb;

    private Vector3 _dir;

    private Animator _animator;

    private Quaternion _targetRotation;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
        _targetRotation = transform.rotation;
    }

    private void Update()
    {
        Move();
        Attack();
    }
    private void Move()
    {
        //����
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        //�����x�N�g�����擾
        _dir = new Vector3(moveX, 0, moveZ).normalized;
        //player�̃��[���h���W�����C���J�����̃��[�J�����W�ɕϊ�����B
        _dir = Camera.main.transform.TransformDirection(_dir);
        _dir.y = 0;
        _animator.SetFloat("Move", _dir.magnitude, 0.1f, Time.deltaTime);
        float rotationSpeed = 600 * Time.deltaTime;
        //���x���[���łȂ����
        if (_dir.magnitude > 0.5f)
        {
            //�^�[���̏���
            _targetRotation = Quaternion.LookRotation(_dir, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, _targetRotation, 3);
        }
        _rb.velocity = _dir * _moveSpeed + new Vector3(0f, _rb.velocity.y, 0f);
    }

    private void Attack()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            _animator.SetTrigger("Attack");
        }
    }
}

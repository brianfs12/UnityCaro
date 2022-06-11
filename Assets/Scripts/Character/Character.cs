using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]

public class Character : MonoBehaviour
{
    private Rigidbody2D _rb2D;
    private SpriteRenderer _spr;
    private Animator _anim;

    [SerializeField, Range(0.01f, 105f)]
    private float _moveSpeed;
    [SerializeField, Range(0.01f, 15f)]
    private float _jumpForce;

    public float MoveSpeed { get => _moveSpeed; set => _moveSpeed = value; }
    public float JumpForce { get => _jumpForce; set => _jumpForce = value; }

    private void Awake()
    {
        _rb2D = GetComponent<Rigidbody2D>();
        _spr = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();
    }

    public Rigidbody2D Rigidbody2D => _rb2D;
    public SpriteRenderer SpriteRenderer => _spr;
    public Animator Animator => _anim;



}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    [SerializeField] private ContactFilter2D _groundFilter;
    Collider2D _coli2D;
    private bool _isGrounded;

    void Awake()
    {
        _coli2D = GetComponent<Collider2D>();
    }

    void FixedUpdate()
    {
        _isGrounded = Contact;
    }
    public bool isGrounding => _isGrounded;
    private bool Contact => Physics2D.IsTouching(_coli2D, _groundFilter);
}

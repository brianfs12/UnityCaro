using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private AddMovementInputController _addMovementInputController;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _addMovementInputController = GetComponent<AddMovementInputController>();
    }
    public bool bFlipSpriteX => _addMovementInputController.Direction.x < 0f ? true : _addMovementInputController.Direction.x > 0f ? false : _spriteRenderer.flipX;
//    public bool bFlipSpriteX => _addMovementInputController.Direction.x < 0f ? gameObject.transform.Rotate(0, 180, 0) : gameObject.transform.Rotate(0, -180, 0);
}

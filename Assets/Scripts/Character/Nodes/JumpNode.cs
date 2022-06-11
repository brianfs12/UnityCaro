using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class JumpNode : Unit
{
    [DoNotSerialize, PortLabelHidden]
    private ControlInput _controlInput;
    [DoNotSerialize, PortLabelHidden]
    private ControlOutput _controlOutput;

    [DoNotSerialize]
    private ValueInput _rigidbody2DInput;
    [DoNotSerialize]
    private ValueInput _jumpForceInput;
    [DoNotSerialize]
    private ValueInput _directionInput;

    private Rigidbody2D _rigidbody2D;
    private float _jumpForce;
    private Vector2 _direction;

    protected override void Definition()
    {
        _controlInput = ControlInput("Input trigger", flow =>
        {
            ExecuteDefinition(flow);
            return _controlOutput;
        });

        _rigidbody2DInput = ValueInput<Rigidbody2D>("Rigidbody2D", null);
        _jumpForceInput = ValueInput<float>("Jump force", 0f);
        _directionInput = ValueInput<Vector2>("Direction", Vector2.up);

        _controlOutput = ControlOutput("Output trigger");
    }

    private void ExecuteDefinition(Flow flow)
    {
        _rigidbody2D = flow.GetValue<Rigidbody2D>(_rigidbody2DInput);
        _jumpForce = flow.GetValue<float>(_jumpForceInput);
        _direction = flow.GetValue<Vector2>(_directionInput);

        ApplyJump();
    }

    private void ApplyJump() => _rigidbody2D.AddForce(_direction * _jumpForce, ForceMode2D.Impulse);
}
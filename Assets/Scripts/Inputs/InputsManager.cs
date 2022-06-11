using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputsManager : MonoBehaviour
{
    private GameInputs _gameInputs;

    private void Awake()
    {
        _gameInputs = new GameInputs();
    }

    private void OnEnable()
    {
        _gameInputs.Enable();
    }

    private void OnDisable()
    {
        _gameInputs.Disable();
    }

    public GameInputs GameInputs { get => _gameInputs; set => _gameInputs = value; }

}

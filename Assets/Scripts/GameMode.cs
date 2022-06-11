using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class GameMode : MonoBehaviour
{
    [SerializeField]
    private InputsManager _inputsManager;

    public InputsManager InputsManager => _inputsManager;
}

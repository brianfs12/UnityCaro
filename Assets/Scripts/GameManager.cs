using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private GameMode _gameMode;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            _gameMode = GameObject.FindGameObjectWithTag("GameMode").GetComponent<GameMode>();
            DontDestroyOnLoad(gameObject);
        }
    }

    public GameMode GameMode { get => _gameMode; set => _gameMode = value; }
}

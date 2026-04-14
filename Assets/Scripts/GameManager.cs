using Unity.Profiling;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState state;

    public static event Action <GameState> OnGameStateChanged;

    void Awake()
    {
        Instance = this;
    }
    
    public void  UpdateGameState (GameState newState)
    {
        state = newState;

        switch(newState)
        {
            case GameState.LoseState:
                break;
            case GameState.WinState:
                break;
        }

        // If any state changed, then notify that it has
        OnGameStateChanged?.Invoke(newState);


    }


    public enum GameState
    {
        LoseState,
        WinState
    }
}

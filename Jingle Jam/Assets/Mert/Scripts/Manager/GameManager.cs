using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public GameState currentGameState;
    public System.Action<GameState> OnGameStateChanged;
    
    public void ChangeGameState(GameState state)
    {
        if (currentGameState != state)
        {
            currentGameState = state;
            OnGameStateChanged?.Invoke(currentGameState);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // All managers should hold their respective object's state machine 
    public G_StatePaused statePaused { get; set; }
    public G_StateStartMenu stateMenu { get; set; }
    public G_StatePlaying statePlaying { get; set; }

    public GameState currentState;
    public static GameManager Instance = null;

    // Objects for state machine to handle
    //public GameObject m_pauseMenu;
    //public GameObject m_deathMenu;

    private void Awake()
    {
        stateMenu = new G_StateStartMenu(this);
        statePlaying = new G_StatePlaying(this);
        statePaused = new G_StatePaused(this);

        SetInstance();
        UnPauseGame();
    }

    private void Start()
    {
        NewGameState(statePlaying);
    }

    void SetInstance()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void UnPauseGame()
    {
        statePaused.UnPauseGame();
    }

    public void NewGameState(State newState)
    {
        if (currentState != null)
        {
            currentState.StateExit();
        }
        currentState = newState;
        currentState.StateEnter();
    }

    public void ResetGame()
    {
        //stateDead.ResetGame();
    }

}

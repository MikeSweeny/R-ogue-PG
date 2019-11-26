using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public StateDead stateDead { get; set; }
    public StatePaused statePaused { get; set; }
    public StateMenu stateMenu { get; set; }
    public StatePlaying statePlaying { get; set; }
    public GameState currentState;

    public static GameManager Instance = null;
    public bool m_isPaused = false;
    public GameObject m_pauseMenu;
    public GameObject m_deathMenu;

    private void Awake()
    {
        stateMenu = new StateMenu(this);
        statePlaying = new StatePlaying(this);
        statePaused = new StatePaused(this);
        stateDead = new StateDead(this);

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

    public void NewGameState(GameState newState)
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
        stateDead.ResetGame();
    }

}

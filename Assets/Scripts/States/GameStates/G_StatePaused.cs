using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G_StatePaused : State
{
    public G_StatePaused(GameManager gm) : base(gm) { }


    // Start is called before the first frame update
    public override void StateEnter()
    {
        Debug.Log("State: Paused");
        TogglePause();

    }

    public override void StateExit()
    {
    }

    public override void StateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }
    public void TogglePause()
    {
        if (GameManager.Instance.currentState == GameManager.Instance.statePaused)
        {
            UnPauseGame();
        }
        else
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        //GameManager.Instance.m_pauseMenu.SetActive(true);
    }

    public void UnPauseGame()
    {
        GameManager.Instance.NewGameState(GameManager.Instance.statePlaying);
        Time.timeScale = 1;

        //Set your pause screen to inactive here
    }

}

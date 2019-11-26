using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateDead : GameState
{
    public StateDead(GameManager gm) : base(gm) { }
    // Start is called before the first frame update
    public override void StateEnter()
    {
        Debug.Log("State: Dead");
        ShowDeathMenu();
    }

    public override void StateExit()
    {
    }

    public override void StateUpdate()
    {

    }

    public void ResetGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ShowDeathMenu()
    {
        Time.timeScale = 0;
        GameManager.Instance.m_isPaused = true;
        GameManager.Instance.m_deathMenu.SetActive(true);
    }
}

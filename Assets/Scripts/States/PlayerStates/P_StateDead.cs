using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P_StateDead : State
{
    public P_StateDead(GameManager gm) : base(gm) { }
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
        GameManager.Instance.m_deathMenu.SetActive(true);
    }
}

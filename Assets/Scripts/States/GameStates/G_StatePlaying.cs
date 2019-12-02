using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class G_StatePlaying : GameState
{
    public G_StatePlaying(GameManager gm) : base(gm) { }

    public override void StateEnter()
    {
        Debug.Log("State: Playing");
    }

    public override void StateExit()
    {

    }

    public override void StateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameManager.Instance.NewGameState(GameManager.Instance.statePaused);
        }
    }

    public void DisplayPauseMenu(bool isPaused)
    {
        Cursor.visible = isPaused;
    }

}


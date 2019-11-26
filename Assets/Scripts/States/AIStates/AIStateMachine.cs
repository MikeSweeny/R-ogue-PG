using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerState
{
    protected GameManager m_gameManager;
    public PlayerState(GameManager gm)
    {
        m_gameManager = gm;
    }

    public abstract void StateEnter();
    public abstract void StateExit();
    public abstract void StateUpdate();
}

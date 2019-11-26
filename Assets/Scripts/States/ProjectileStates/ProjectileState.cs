using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ProjectileState
{
    protected GameManager m_gameManager;
    public ProjectileState(GameManager gm)
    {
        m_gameManager = gm;
    }

    public abstract void StateEnter();
    public abstract void StateExit();
    public abstract void StateUpdate();
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIState
{
    protected GameManager m_gameManager;
    public AIState(GameManager gm)
    {
        m_gameManager = gm;
    }

    public abstract void StateEnter();
    public abstract void StateExit();
    public abstract void StateUpdate();
}

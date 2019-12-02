using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerState
{
    protected PlayerManager m_playerManager;
    public PlayerState(PlayerManager pm)
    {
        m_playerManager = pm;
    }

    public abstract void StateEnter();
    public abstract void StateExit();
    public abstract void StateUpdate();

}

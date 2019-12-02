using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIState
{
    protected AiController m_AiController;
    public AIState(AiController ai)
    {
        m_AiController = ai;
    }

    public abstract void StateEnter();
    public abstract void StateExit();
    public abstract void StateUpdate();

}

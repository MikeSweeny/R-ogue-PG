using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ProjectileState
{
    protected Projectile m_projectile;
    public ProjectileState(Projectile p)
    {
        m_projectile = p;
    }

    public abstract void StateEnter();
    public abstract void StateExit();
    public abstract void StateUpdate();

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : Interactable
{
    public void LeverOn()
    {
        setIsOn(true);
    }
    public void LeverOff()
    {
        setIsOn(false);
    }
}

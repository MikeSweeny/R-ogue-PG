using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool isOn = false;

    public virtual void Act()
    {

    }
    public bool getIsOn()
    {
        return isOn;
    }
    public void setIsOn(bool change)
    {
        isOn = change;
    }
}

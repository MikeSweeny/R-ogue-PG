using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLever : Interactable
{
    public GameObject door;
    public GameObject leverOn;
    public GameObject leverOff;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LeverOff();
            door.SetActive(false);
        }
        else if (collision.gameObject.tag == "Player")
        {
            LeverOn();
            door.SetActive(true);
        }
    }
    public void LeverOn()
    {
        leverOn.SetActive(true);
        leverOff.SetActive(false);
        setIsOn(true);
    }
    public void LeverOff()
    {
        leverOn.SetActive(false);
        leverOff.SetActive(true);
        setIsOn(false);
    }
}

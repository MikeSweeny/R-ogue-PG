using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLever : Interactable
{
    public GameObject spawnDoor;
    public GameObject ritualDoor;
    public GameObject libraryDoor;
    public GameObject leverOn;
    public GameObject leverOff;
    public AudioSource audioIdle;
    public AudioSource audioBattle;
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

    public override void Act()
    {
        if(isOn)
        {
            LeverOff();
            spawnDoor.SetActive(true);
            ritualDoor.SetActive(false);
            libraryDoor.SetActive(false);
            audioIdle.Play();
            audioBattle.Stop();
        }
        else
        {
            LeverOn();
            spawnDoor.SetActive(false);
            ritualDoor.SetActive(true);
            libraryDoor.SetActive(true);
            audioIdle.Stop();
            audioBattle.Play();
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLever : Interactable
{
    public GameObject door;
    public GameObject leverOn;
    public GameObject leverOff;
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

    protected override void Act()
    {
        if(isOn && gameObject.tag == "RitualRoomLever")
        {
            Vector3 newPosition = new Vector3(door.transform.position.x, door.transform.position.y, 20);
            door.transform.position = newPosition;
            LeverOff();
        }
        else
        {
            Vector3 newPosition = new Vector3(door.transform.position.x, door.transform.position.y, 0);
            door.transform.position = newPosition;
            LeverOn();
        }
        if (isOn && gameObject.tag == "LibraryRoomLever")
        {
            Vector3 newPosition = new Vector3(20, door.transform.position.y, door.transform.position.z);
            door.transform.position = newPosition;
            LeverOff();
        }
        else
        {
            Vector3 newPosition = new Vector3(0, door.transform.position.y, door.transform.position.z);
            door.transform.position = newPosition;
            LeverOn();
        }
    }
}

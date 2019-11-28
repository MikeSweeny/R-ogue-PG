using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodAlter : Interactable
{
    private int maxZ = 3;
    private int minZ = -2;
    public Transform currentZ;
    private int maxBlood = 100;
    private int minBlood = 0;
    private int currentBlood = 100;
    public GameObject blood;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PlayerInteract();
        }
       if(currentZ.transform.position.z < maxZ && currentZ.transform.position.z > minZ)
        {
            for (int i = 0; i < 2; i++)
            {
                Vector3 temp = blood.transform.position;
                temp.z += 1;
                Vector3 newPosition = new Vector3(blood.transform.position.x, blood.transform.position.y, temp.z);
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        setIsOn(true);
    }
    public void PlayerInteract()
    {
        //if (isOn && currentHealth < maxHealth && currentBlood > minBlood && currentBlood <= maxBlood)
        //{
        //    bones = bones - 1;
        //    currentBlood = currentBlood - 1;
        //    currentHealth = currentHealth + 1;
        //    Vector3 temp = blood.transform.position;
        //    temp.z -= 1;
        //    Vector3 newPosition = new Vector3(blood.transform.position.x, blood.transform.position.y, temp.z);
        //}
    }
}

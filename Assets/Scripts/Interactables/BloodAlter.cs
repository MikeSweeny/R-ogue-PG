﻿using System.Collections;
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
    private int timer = 0;
    public GameObject blood;
    PlayerManager pM;
    // Update is called once per frame
    public void Start()
    {
        pM = SceneManager.Instance.GetPlayerManager();
    }
    void Update()
    {
        Act();
        CountDown();
        TimerReset();
    }
    public override void Act()
    {
        if (pM.GetHealth() < pM.GetMaxHealth() && currentBlood > minBlood)
        {
            pM.SetBones(-1);
            currentBlood = currentBlood - 1;
            pM.SetHealth(+1);
            Vector3 temp = blood.transform.position;
            temp.z -= 1;
            Vector3 newPosition = new Vector3(blood.transform.position.x, blood.transform.position.y, temp.z);
        }
    }
    public void CountDown()
    {
        timer++;
        if (timer == 300 && currentBlood >= minBlood && currentBlood < maxBlood)
        {
            Vector3 resetPosition = new Vector3(blood.transform.position.x, blood.transform.position.y, 3);
        }
    }
    public void TimerReset()
    {
        if (timer == 300)
        {
            timer = 0;
        }
    }
}

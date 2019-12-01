using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodAlter : Interactable
{
    public Transform currentZ;
    private static int maxBlood = 100;
    private int minBlood = 0;
    private static int currentBlood = maxBlood;
    private int timer = 0;
    public GameObject blood;
    PlayerManager pM;

    public bool startCountDown = false;
    // Update is called once per frame
    public void Start()
    {
        pM = SceneManager.Instance.GetPlayerManager();
    }
    void Update()
    {
        CountDown();
        if (currentBlood == 0)
        {
            startCountDown = true;
        }
    }
    public override void Act()
    {
        if (pM.GetHealth() < pM.GetMaxHealth() && currentBlood > minBlood && pM.GetBones() > 0)
        {
            pM.SetBones(-1);
            currentBlood = currentBlood - 1;
            pM.SetHealth(+1);
            Vector3 temp = blood.transform.position;
            temp.z -= 5;
            Vector3 newPosition = new Vector3(blood.transform.position.x, blood.transform.position.y, temp.z);
        }
    }
    public void CountDown()
    {
        if(startCountDown)
        {
            timer++;
            if (timer == 300 && currentBlood >= minBlood && currentBlood < maxBlood)
            {
                Vector3 resetPosition = new Vector3(blood.transform.position.x, blood.transform.position.y, 3);
            }
            if (timer == 300)
            {
                timer = 0;
                startCountDown = false;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodAlter : Interactable
{
    //variables used
    private static int maxBlood = 5;
    private int minBlood = 0;
    private int bloodRegen = 0;
    private static int currentBlood = maxBlood;
    private int timer = 0;
    //The blood game object inside the tube that will move
    public GameObject blood;

    PlayerManager pM;
    public AudioSource sfx;

    public bool startCountDown = false;

    // Update is called once per frame
    public void Start()
    {
        pM = SceneManager.Instance.GetPlayerManager();
    }
    void Update()
    {
        CountDown();
    }
    public override void Act()
    {
        if (pM.GetHealth() < pM.GetMaxHealth() && currentBlood > minBlood && pM.GetBones() > 0)
        {
            sfx.Play();
            pM.SetBones(-1);
            currentBlood = currentBlood - 1;
            pM.SetHealth(+20);
            blood.transform.position -= transform.up;
            if(pM.GetHealth() > 1000)
            {
                pM.SetHealth(1000 - pM.GetHealth());
            }
        }
        if (currentBlood == 0)
        {
            startCountDown = true;
        }
    }
    public void CountDown()
    {
        if(startCountDown)
        {
            Debug.Log(timer);
            timer++;
            if (timer == 500)
            {
                blood.transform.position += transform.up;
                bloodRegen = bloodRegen + 1;
                timer = 0;
                if (bloodRegen == 5)
                {
                    timer = 0;
                    bloodRegen = 0;
                    currentBlood = 5;
                    startCountDown = false;
                }
            }
        }
    }
}

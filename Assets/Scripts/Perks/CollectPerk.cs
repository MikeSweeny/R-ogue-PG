using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPerk : MonoBehaviour
{
    public HealthPerk dp1, dp2, dp3;
    public HealthPerk hp1, hp2, hp3;
    public AttackPerk ap1, ap2, ap3;
    public SpeedPerk sp1, sp2, sp3;
    public MiscPerk mp1, mp2, mp3;
    public RarePerk rp1, rp2, rp3, rp4, rp5, rp6, rp7;
    PlayerManager player;

    private void Start()
    {
        player = SceneManager.Instance.GetPlayerManager();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // This whole script can be cleaned up easily with arrays and forloops but Im strapped for time and this is what I came up with.
            if (CompareTag("HealthPerk1"))
            {
                int pHealth;
                pHealth = player.GetHealth();
                Debug.Log("Current Health :" + pHealth);

                player.SetMaxHealth(+hp1.healthIncrease);
                player.SetHealth(+hp1.healthIncrease);
                int pHpTesting;
                pHpTesting = player.GetHealth();
                Debug.Log("New Health :" + pHpTesting);
            }
            if (CompareTag("HealthPerk2"))
            {
                int pHealth;
                pHealth = player.GetHealth();
                Debug.Log("Current Health :" + pHealth);

                player.SetMaxHealth(+hp2.healthIncrease);
                player.SetHealth(+hp2.healthIncrease);
                int pHpTesting;
                pHpTesting = player.GetHealth();
                Debug.Log("New Health :" + pHpTesting);
            }
            if (CompareTag("HealthPerk3"))
            {
                int pHealth;
                pHealth = player.GetHealth();
                Debug.Log("Current Health :" + pHealth);

                player.SetMaxHealth(+hp3.healthIncrease);
                player.SetHealth(+hp3.healthIncrease);
                int pHpTesting;
                pHpTesting = player.GetHealth();
                Debug.Log("New Health :" + pHpTesting);
            }
            if (CompareTag("AttackPerk1"))
            {
                float pAttack;
                pAttack = player.GetProjDamage();
                Debug.Log("Current Attack :" + pAttack);

                player.SetProjDamage(+ap1.DamageIncrease);
                float pHpTesting;
                pHpTesting = player.GetProjDamage();
                Debug.Log("New Attack :" + pHpTesting);
            }
            if (CompareTag("AttackPerk2"))
            {
                float pAttack;
                pAttack = player.GetProjDamage();
                Debug.Log("Current Attack :" + pAttack);
                player.SetProjDamage(+ap2.DamageIncrease);
                float pHpTesting;
                pHpTesting = player.GetProjDamage();
                Debug.Log("New Attack :" + pHpTesting);
            }
            if (CompareTag("AttackPerk3"))
            {
                float pAttack;
                pAttack = player.GetProjDamage();
                Debug.Log("Current Attack :" + pAttack);
                player.SetProjDamage(+ap3.DamageIncrease);
                float pHpTesting;
                pHpTesting = player.GetProjDamage();
                Debug.Log("New Attack :" + pHpTesting);
            }
            if (CompareTag("DefencePerk1"))
            {
                float pDefence;
                pDefence = player.GetDefense();
                Debug.Log("Current Defence :" + pDefence);
                player.SetDefense(+dp1.defenceIncrease);
                float pHpTesting;
                pHpTesting = player.GetDefense();
                Debug.Log("New Defence :" + pHpTesting);
            }
            if (CompareTag("DefencePerk2"))
            {
                float pDefence;
                pDefence = player.GetDefense();
                Debug.Log("Current Defence :" + pDefence);
                player.SetDefense(+dp2.defenceIncrease);
                float pHpTesting;
                pHpTesting = player.GetDefense();
                Debug.Log("New Defence :" + pHpTesting);

            }
            if (CompareTag("DefencePerk3"))
            {
                float pDefence;
                pDefence = player.GetDefense();
                Debug.Log("Current Defence :" + pDefence);
                player.SetDefense(+dp3.defenceIncrease);
                float pHpTesting;
                pHpTesting = player.GetDefense();
                Debug.Log("New Defence :" + pHpTesting);

            }
            if (CompareTag("SpeedPerk1"))
            {
                float pProjSpeed;
                pProjSpeed = player.GetProjSpeed();
                Debug.Log("Current AttackSpeed :" + pProjSpeed);

                player.SetProjSpeed(+sp1.speedIncrease);
                float pHpTesting;
                pHpTesting = player.GetProjSpeed();
                Debug.Log("New AttackSpeed :" + pHpTesting);
            }
            if (CompareTag("SpeedPerk2"))
            {
                float pProjSpeed;
                pProjSpeed = player.GetProjSpeed();
                Debug.Log("Current AttackSpeed :" + pProjSpeed);

                player.SetProjSpeed(+sp2.speedIncrease);
                float pHpTesting;
                pHpTesting = player.GetProjSpeed();
                Debug.Log("New AttackSpeed :" + pHpTesting);
            }
            if (CompareTag("SpeedPerk3"))
            {
                float pProjSpeed;
                pProjSpeed = player.GetProjSpeed();
                Debug.Log("Current AttackSpeed :" + pProjSpeed);

                player.SetProjSpeed(+sp3.speedIncrease);
                float pHpTesting;
                pHpTesting = player.GetProjSpeed();
                Debug.Log("New AttackSpeed :" + pHpTesting);
            }
            if (CompareTag("MiscPerk1"))
            {
                int pLifeSteal;
                pLifeSteal = player.GetLifestealPercent();
                Debug.Log("Current LifeSteal Percent :" + pLifeSteal);

                player.SetLifestealPercent(+mp1.lifestealPct);
                int pHpTesting;
                pHpTesting = player.GetLifestealPercent();
                Debug.Log("New LifeSteal Percent :" + pHpTesting);
            }
            if (CompareTag("MiscPerk2"))
            {
                int pLifeSteal;
                pLifeSteal = player.GetLifestealPercent();
                Debug.Log("Current LifeSteal Percent :" + pLifeSteal);

                player.SetLifestealPercent(+mp2.lifestealPct);
                int pHpTesting;
                pHpTesting = player.GetLifestealPercent();
                Debug.Log("New LifeSteal Percent :" + pHpTesting);
            }
            if (CompareTag("MiscPerk3"))
            {
                int pLifeSteal;
                pLifeSteal = player.GetLifestealPercent();
                Debug.Log("Current LifeSteal Percent :" + pLifeSteal);

                player.SetLifestealPercent(+mp3.lifestealPct);
                int pHpTesting;
                pHpTesting = player.GetLifestealPercent();
                Debug.Log("New LifeSteal Percent :" + pHpTesting);
            }
            if (CompareTag("RarePerk1"))
            {
                bool pIsSeeking;
                pIsSeeking = player.GetActivePerks("seeking");
                Debug.Log("Current SeekingStatus :" + pIsSeeking);
                player.ActivatePerk("seeking");
                bool pHpTesting;
                pHpTesting = player.GetActivePerks("seeking");
                Debug.Log("New SeekingStatus :" + pHpTesting);
            }
            if (CompareTag("RarePerk2"))
            {
                bool pMagnet;
                pMagnet = player.GetActivePerks("magnet");
                Debug.Log("Current MagnetStatus :" + pMagnet);

                player.ActivatePerk("magnet");
                bool pHpTesting;
                pHpTesting = player.GetActivePerks("magnet");
                Debug.Log("New MagentStatus :" + pHpTesting);
            }
            if (CompareTag("RarePerk3"))
            {
                bool pLottery;
                pLottery = player.GetActivePerks("lottery");
                Debug.Log("Current LotteryStatus :" + pLottery);

                player.ActivatePerk("lottery");
                bool pHpTesting;
                pHpTesting = player.GetActivePerks("lottery");
                Debug.Log("New LotteryStatus :" + pHpTesting);
            }
            if (CompareTag("RarePerk4"))
            {
                bool pLevitate;
                pLevitate = player.GetActivePerks("levitate");
                Debug.Log("Current LevitateStatus :" + pLevitate);

                player.ActivatePerk("levitate");
                bool pHpTesting;
                pHpTesting = player.GetActivePerks("levitate");
                Debug.Log("New LevitateStatus :" + pHpTesting);
            }
            if (CompareTag("RarePerk5"))
            {
                bool pExplosive;
                pExplosive = player.GetActivePerks("explosive");
                Debug.Log("Current ExplosiveStatus :" + pExplosive);

                player.ActivatePerk("explosive");
                bool pHpTesting;
                pHpTesting = player.GetActivePerks("explosive");
                Debug.Log("New ExplosiveStatus :" + pHpTesting);
            }
            if (CompareTag("RarePerk6"))
            {
                bool pHover;
                pHover = player.GetActivePerks("hover");
                Debug.Log("Current HoverStatus :" + pHover);

                player.ActivatePerk("hover");
                bool pHpTesting;
                pHpTesting = player.GetActivePerks("hover");
                Debug.Log("New HoverStatus :" + pHpTesting);
            }
            if (CompareTag("RarePerk7"))
            {
                bool pFlight;
                pFlight = player.GetActivePerks("flight");
                Debug.Log("Current FlightStatus :" + pFlight);

                player.ActivatePerk("flight");
                bool pHpTesting;
                pHpTesting = player.GetActivePerks("flight");
                Debug.Log("New FlightStatus :" + pHpTesting);
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerksManager : MonoBehaviour
{

    public GameObject PerksDias;

    public GameObject defaultPerk;
    public GameObject AttackPerk1, AttackPerk2, AttackPerk3;
    public GameObject DefencePerk1, DefencePerk2, DefencePerk3;
    public GameObject SpeedPerk1, SpeedPerk2, SpeedPerk3;
    public GameObject RarePerk1, RarePerk2, RarePerk3, RarePerk4, RarePerk5, RarePerk6;
    public GameObject MiscPerk1, MiscPerk2, MiscPerk3, MiscPerk4, MiscPerk5, MiscPerk6;

    private static int MAX_PERKS;   // set the max number of perks we can have in the project
    private bool isUnique = false;  // Sets the Perk to Unique or not, so we can only pick up one or not
    private int RandPerk;

    private static float timer;

    private void Awake()
    {
        RandomPerkPick();
    }
    private void Update()
    {

    }

    public void RandomPerkPick()
    {
            RandPerk = Random.Range(1, 21);
        // Get a Random number, that number gets a randm perk, applies it to the dias and allows the player to interact with it, if they do, the perk will be activated on the player adding stats or abilities.
        if (RandPerk == 1)
        {
            // Attack Boost 1
            Debug.Log("1: AttackBoost1 Randomed");
            defaultPerk.SetActive(false);
            AttackPerk1.SetActive(true);
        }
        else if (RandPerk == 2)
        {
            //Speed Boost 1
            Debug.Log("2: AttackBoost2 Randomed");
            defaultPerk.SetActive(false);
            AttackPerk2.SetActive(true);

        }
        else if (RandPerk == 3)
        {
            //DefenceBoost 1
            Debug.Log("3: AttackBoost3 Randomed");
            defaultPerk.SetActive(false);
            AttackPerk3.SetActive(true);

        }
        else if (RandPerk == 4)
        {
            //RarePerk
            Debug.Log("4: SpeedBoost1 Randomed");
            defaultPerk.SetActive(false);
            SpeedPerk1.SetActive(true);

        }
        else if (RandPerk == 5) {
            Debug.Log("5: SpeedBoost2 Randomed");
            defaultPerk.SetActive(false);
            SpeedPerk2.SetActive(true);
        }
        else if (RandPerk == 6) {
            Debug.Log("6: SpeedBoost3 Randomed");
            defaultPerk.SetActive(false);
            SpeedPerk3.SetActive(true);
        }
        else if (RandPerk == 7)
        {
            Debug.Log("7: DefenceBoost1 Randomed");
            defaultPerk.SetActive(false);
            DefencePerk1.SetActive(true);
        }
        else if (RandPerk == 8)
        {
            Debug.Log("8: DefenceBoost2 Randomed");
            defaultPerk.SetActive(false);
            DefencePerk2.SetActive(true);
        }
        else if (RandPerk == 9)
        {
            Debug.Log("9: DefenceBoost3 Randomed");
            defaultPerk.SetActive(false);
            DefencePerk3.SetActive(true);
        }
        else if (RandPerk == 10)
        {
            Debug.Log("10: RarePerk1 Randomed");
            defaultPerk.SetActive(false);
            RarePerk1.SetActive(true);
        }
        else if (RandPerk == 11)
        {
            Debug.Log("11: RarePerk2 Randomed");
            defaultPerk.SetActive(false);
            RarePerk2.SetActive(true);
        }
        else if (RandPerk == 12)
        {
            Debug.Log("12: RarePerk3 Randomed");
            defaultPerk.SetActive(false);
            RarePerk3.SetActive(true);
        }
        else if (RandPerk == 13)
        {
            Debug.Log("13: RarePerk4 Randomed");
            defaultPerk.SetActive(false);
            RarePerk4.SetActive(true);
        }
        else if (RandPerk == 14)
        {
            Debug.Log("14: RarePerk5 Randomed");
            defaultPerk.SetActive(false);
            RarePerk5.SetActive(true);
        }
        else if (RandPerk == 15)
        {
            Debug.Log("15: RarePerk6 Randomed");
            defaultPerk.SetActive(false);
            RarePerk6.SetActive(true);
        }
        else if (RandPerk == 16)
        {
            Debug.Log("16: MiscPerk1 Randomed");
            defaultPerk.SetActive(false);
            MiscPerk1.SetActive(true);
        }
        else if (RandPerk == 17)
        {
            Debug.Log("17: MiscPerk2 Randomed");
            defaultPerk.SetActive(false);
            MiscPerk2.SetActive(true);
        }
        else if (RandPerk == 18)
        {
            Debug.Log("18: MiscPerk3 Randomed");
            defaultPerk.SetActive(false);
            MiscPerk3.SetActive(true);
        }
        else if (RandPerk == 19)
        {
            Debug.Log("19: MiscPerk4 Randomed");
            defaultPerk.SetActive(false);
            MiscPerk4.SetActive(true);
        }
        else if (RandPerk == 20)
        {
            Debug.Log("20: MiscPerk5 Randomed");
            defaultPerk.SetActive(false);
            MiscPerk5.SetActive(true);
        }
        else if (RandPerk == 21)
        {
            Debug.Log("21: MiscPerk6 Randomed");
            defaultPerk.SetActive(false);
            MiscPerk6.SetActive(true);
        }
        else
        {
            Debug.Log("Why did it hit this?");
        }




    }

    public void ClearPerks()
    {
        defaultPerk.SetActive(true);

        AttackPerk1.SetActive(false);
        AttackPerk2.SetActive(false);
        AttackPerk3.SetActive(false);

        SpeedPerk1.SetActive(false);
        SpeedPerk2.SetActive(false);
        SpeedPerk3.SetActive(false);

        DefencePerk1.SetActive(false);
        DefencePerk2.SetActive(false);
        DefencePerk3.SetActive(false);

        RarePerk1.SetActive(false);
        RarePerk2.SetActive(false);
        RarePerk3.SetActive(false);
        RarePerk4.SetActive(false);
        RarePerk5.SetActive(false);
        RarePerk6.SetActive(false);

        MiscPerk1.SetActive(false);
        MiscPerk2.SetActive(false);
        MiscPerk3.SetActive(false);
        MiscPerk4.SetActive(false);
        MiscPerk5.SetActive(false);
        MiscPerk6.SetActive(false);

    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Health Perk", menuName = "Perks/Health")]
public class HealthPerk : PerkObject
{
    public int healthIncrease = 2;
    public int defenceIncrease;
    PlayerManager player;

    public override void AddPerk()
    {
        throw new System.NotImplementedException();
    }

    public void Awake()
    {
        // This is so we dont have to set the type everytime we make one

        type = PerkType.Health;

    }
    public int GetHealthIncrease()
    {
        return healthIncrease;
    }

    public override void Initialize()
    {
        throw new System.NotImplementedException();
    }
}

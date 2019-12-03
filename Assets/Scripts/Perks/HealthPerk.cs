using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Health Perk", menuName = "Perks/Health")]
public class HealthPerk : PerkObject
{
    public int healthIncrease;
    public int defenceIncrease;
    PlayerManager player;



    public void Awake()
    {
        // This is so we dont have to set the type everytime we make one
        type = PerkType.Health;

    }
    
    public override void Initialize()
    {
        healthIncrease = 250;
        defenceIncrease = 5;
    }

    public override void AddPerk()
    {

    }
}

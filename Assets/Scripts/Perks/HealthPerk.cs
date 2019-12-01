using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Health Perk", menuName = "Perks/Health")]
public class HealthPerk : PerkObject
{
    public int healthIncrease;
    public int defenceIncrease;

    public void Awake()
    {
        // This is so we dont have to set the type everytime we make one

        type = PerkType.Health;
        
    }
}

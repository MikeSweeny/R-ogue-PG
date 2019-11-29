using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Speed Perk", menuName = "Perks/Speed")]
public class SpeedPerk : Perk
{
    public int speedIncrease;
    public void Awake()
    {
        // This is so we dont have to set the type everytime we make one

        type = PerkType.Speed;
    }
}

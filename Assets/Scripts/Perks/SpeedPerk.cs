using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Speed Perk", menuName = "Perks/Speed")]
public class SpeedPerk : PerkObject
{
    public int speedIncrease;

    public override void AddPerk()
    {
        throw new System.NotImplementedException();
    }

    public void Awake()
    {
        // This is so we dont have to set the type everytime we make one

        type = PerkType.Speed;
    }

    public override void Initialize()
    {
        throw new System.NotImplementedException();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Damage Perk", menuName = "Perks/Attack")]
public class AttackPerk : PerkObject
{
    public int DamageIncrease;

    public override void AddPerk()
    {
        throw new System.NotImplementedException();
    }

    public void Awake()
    {
        // This is so we dont have to set the type everytime we make one
        type = PerkType.Damage;
    }

    public override void Initialize()
    {
        throw new System.NotImplementedException();
    }
}

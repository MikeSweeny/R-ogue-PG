using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Misc Perk", menuName = "Perks/Misc")]
public class MiscPerk : PerkObject
{
    public int lifestealPct;
    public override void AddPerk()
    {
        throw new System.NotImplementedException();
    }

    public void Awake()
    {
        // This is so we dont have to set the type everytime we make one

        type = PerkType.Misc;
    }

    public override void Initialize()
    {
        throw new System.NotImplementedException();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Rare Perk", menuName = "Perks/Rare")]
public class RarePerk : PerkObject
{
    public bool seeking;
    public bool magnet;
    public bool lottery;
    public bool levitate;
    public bool explosive;
    public bool hover;

    public int spreadCount;
    public float bonesCollected;

    public int jumpCount;
    public int lifesteal;

    public override void AddPerk()
    {
        throw new System.NotImplementedException();
    }

    public void Awake()
    {
        // This is so we dont have to set the type everytime we make one

        type = PerkType.Rare;
    }

    public override void Initialize()
    {
        throw new System.NotImplementedException();
    }
}

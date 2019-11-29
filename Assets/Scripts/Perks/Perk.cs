using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PerkType
{
    Damage,
    Speed,
    Health,
    Rare,
    Misc
}

public class Perk : ScriptableObject
{
    public string name;
    public PerkType type;
    public GameObject pedGem;
    public Sprite displayIcon;
    [TextArea(15, 15)]
    public string description;

}

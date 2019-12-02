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

public abstract class PerkObject : ScriptableObject
{
    public int ID;
    public new string name;
    public PerkType type;
    public GameObject pedGem;
    public bool IsStackable;
    public Sprite displayIcon;
    [TextArea(15, 15)]
    public string description;

    public abstract void Initialize(); // Sets up the Perk after its been setup in the Editor
    public abstract void AddPerk();     // Function to add each perk to the player

}
[System.Serializable]
public class perk
{
    public string name;
    public int ID;
    public bool isStackable;
    public perk(PerkObject perk)
    {
        isStackable = perk.IsStackable;
        name = perk.name;
        ID = perk.ID;
    }
}

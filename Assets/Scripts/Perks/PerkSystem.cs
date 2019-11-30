using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PerkSystem", menuName = "PerkSystem/PerkSystem")]

public class PerkSystem : ScriptableObject
// Upon picking up a perk, the Display for the Perks will need to update, changing the default sprite (White box) to the sprite the Perk picked up uses
// if theres alreay a perk, it needs to stack
{
    public List<PerkSlot> Container = new List<PerkSlot>();
    public void AddPerk(Perk _perk, int _amount)
    {
        bool hasPerk = false;
        for (int i = 0; i < Container.Count; i++)
        {
            
            if(Container[i].perk == _perk)
            {
                Container[i].AddAmount(_amount);
                hasPerk = true;
                break;
            }

        }
    }
}
[System.Serializable]
public class PerkSlot
{
    public Perk perk;
    public int amount;
    public PerkSlot(Perk _perk, int _amount)
    {
        perk = _perk;
        amount = _amount;

    }

    public void AddAmount(int value)
    {
        amount += value;

    }
}

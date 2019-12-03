using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PerkSystem", menuName = "PerkSystem/PerkSystem/System")]

public class PerkSystem : ScriptableObject
{
    public PerkHolder container;
    public PerkDataBase database;
    public void AddPerk(PerkObject _perk, int _amount)
    {
        if (_perk.IsStackable == false)
        {
            container.perk.Add(new PerkSlot(_perk.ID, _perk, _amount, _perk.displayIcon));
            return;
        }
        for (int i = 0; i < container.perk.Count; i++)
        {
            if (container.perk[i].perk.ID == _perk.ID)
            {
                container.perk[i].AddAmount(_amount);
                return;
            }
        }
        container.perk.Add(new PerkSlot(_perk.ID, _perk, _amount, _perk.displayIcon));

    }
}
[System.Serializable]
public class PerkHolder
{
    public List<PerkSlot> perk = new List<PerkSlot>();

}

[System.Serializable]
public class PerkSlot
{
    public int ID;
    public PerkObject perk;
    public int amount;
    public GameObject PerkDisp;
    public PerkSlot(int _id, PerkObject _perk, int _amount, GameObject _disp)
    {
        ID = _id;
        perk = _perk;
        amount = _amount;
        PerkDisp = _disp;
    }

    public void AddAmount(int value)
    {
        amount += value;

    }
}

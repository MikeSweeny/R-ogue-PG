using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Perk Database", menuName = "PerkSystem/PerkSystem/Database")]
public class PerkDataBase : ScriptableObject, ISerializationCallbackReceiver // Unity doesnt serialize dictionaries, the is a callback feature that allows us to do so.
{

    // an array that holds all of the items in the game.
    public PerkObject[] Perks;
    // Dictionary to easily import an item and easily return that item
    public Dictionary<int, PerkObject> GetPerks = new Dictionary<int, PerkObject>();


    // We want to make a new dictionary, and clears it so we are not duplicating any of our items
    public void OnAfterDeserialize()
    {
        // When unity serealises the scriptable object, it will automatically populate the dictionary
        // with refrence values based off the items array we create 
        for (int i = 0; i < Perks.Length; i++)
        {
            Perks[i].ID = i;
            GetPerks.Add(i, Perks[i]);
        }
    }

    public void OnBeforeSerialize()
    {
        GetPerks = new Dictionary<int, PerkObject>();
    }
}

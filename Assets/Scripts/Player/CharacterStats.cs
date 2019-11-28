using System;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats
{
    public float BaseValue;

    public float Value
    {
        get
        {
            // If the numbers need to be recalculated or not, so we are not calling CalculateFinalValue() as often
            if (isDirty)
            {
                _value = CalculateFinalValue();
                isDirty = false;

            }
            return _value;
        }
    }

    private bool isDirty = true;
    private float _value;
    private readonly List<StatModifier> statModifiers;

    public CharacterStats(float baseValue)
    {
        BaseValue = baseValue;
        statModifiers = new List<StatModifier>();

    }

    // Adding and Removing Modifiers

    public void AddModifiers(StatModifier mod)
    {
        isDirty = true;
        statModifiers.Add(mod);
        statModifiers.Sort();

    }

    private int CompareModifierOrder(StatModifier a, StatModifier b)
    {
        // If a Stat modifiers Order is lower than b, it is set to be calculated first, if its higher, its set to be calulated last, if its equal no change.
        if (a.Order < b.Order)
            return -1;
        else if (a.Order > b.Order)
            return 1;
        return 0; // if (a.Order == b.Order)
    }

    public bool RemoveModifier(StatModifier mod)
    {
        isDirty = true;
        return statModifiers.Remove(mod);
    }

    private float CalculateFinalValue()
    {
        float finalValue = BaseValue;

        for (int i = 0; i < statModifiers.Count; i++)
        {
            StatModifier mod = statModifiers[i];

            if(mod.Type == StatModType.Flat)
            {
                finalValue += mod.Value;
            }
            else if (mod.Type == StatModType.Percent)
            {
                finalValue *= 1 + mod.Value;
            }
        }

        //Round to 4 digits.
        return (float)Math.Round(finalValue, 4);
    }
}

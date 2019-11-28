using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum StatModType
{
    Flat = 100,           // Flat numbers applied to stats
    PercentAdd = 200,     // Percents addeded together before being applied to stats
    PercentMult = 300,    // Percent miltiplied to stats
}
public class StatModifier : MonoBehaviour
{
    public readonly float Value;
    public readonly StatModType Type;
    public readonly int Order;
    public readonly object Source;

    // Constuctor that requires a value, type and order
    public StatModifier(float value, StatModType type, int order, object source)
    {
        Value = value;
        Type = type;
        Order = order;
        Source = source;
    }
    //Constructor that requires a value and type, then calls the first constructor passing in the value, 
    //type and an int for the type that represents either Flat or Percent(0 or 1 respectively)
    public StatModifier(float value, StatModType type) : this (value, type, (int)type, null) {  }
    public StatModifier(float value, StatModType type, int order) : this(value, type, order, null) { }
    public StatModifier(float value, StatModType type, object source) : this(value, type, (int)type, source) { }

}

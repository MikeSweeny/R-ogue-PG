using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum StatModType
{
    Flat,
    Percent,
}
public class StatModifier : MonoBehaviour
{
    public readonly float Value;
    public readonly StatModType Type;
    public readonly int Order;

    // Constuctor that requires a value, type and order
    public StatModifier(float value, StatModType type, int order)
    {
        Value = value;
        Type = type;
        Order = order;
    }
    //Constructor that requires a value and type, then calls the first constructor passing in the value, 
    //type and an int for the type that represents either Flat or Percent(0 or 1 respectively)
    public StatModifier(float value, StatModType type) : this (value, type, (int)type)
    {

    }
}

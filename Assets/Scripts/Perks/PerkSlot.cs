using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerkSlot : MonoBehaviour
{
    private Perk _perk;
    public Image Image;

    public Perk perk
    {
        get
        {
            return _perk;
        }
        set
        {
            _perk = value;
            if(_perk == null)
            {
                Image.enabled = false;
            }
            else
            {
                Image.sprite = _perk.Icon;
                Image.enabled = true;
            }
        }
    }
    private void OnValidate()
    {
        if (Image == null)
            Image = GetComponent<Image>();
    }
}

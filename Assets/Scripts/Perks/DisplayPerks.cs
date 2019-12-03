using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPerks : MonoBehaviour
{
    public PerkSystem perksystem;

    public int X_SPACE_BETWEEN_PERK;
    public int Y_SPACE_BETWEEN_PERK;
    public int NUM_COLUMNS;
    Dictionary<PerkSlot, GameObject> perkDisplayed = new Dictionary<PerkSlot, GameObject>();

    private void Start()
    {
        CreateDisplay();

    }

    private void Update()
    {
        //UpdateDisplay();
    }

    public void CreateDisplay()
    {
        for (int i = 0; i < perksystem.container.perk.Count; i++)
        {
            var obj = Instantiate(perksystem.container.perk[i].PerkDisp, Vector3.zero, Quaternion.identity, transform);
            obj.GetComponent<RectTransform>().localPosition = getPosition(i);
            obj.GetComponentInChildren<Text>().text = perksystem.container.perk[i].amount.ToString("n0");
        }

    }
    public Vector3 getPosition(int i)
    {
        return new Vector3(X_SPACE_BETWEEN_PERK * (i % NUM_COLUMNS), (-Y_SPACE_BETWEEN_PERK * (i / NUM_COLUMNS)), 0f);
    }
}
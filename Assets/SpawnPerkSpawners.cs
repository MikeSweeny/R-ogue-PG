﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPerkSpawners : MonoBehaviour
{
    float timer;

    public GameObject PerkSpawners;
    private void FixedUpdate()
    {
        timer += Time.deltaTime * 10;
        if (timer >= 50)
        {
            SetActive();
        }
    }
    void SetActive()
    {
        PerkSpawners.SetActive(true);
    }
}

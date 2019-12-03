using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizedPerk : MonoBehaviour
{
    public Perks[] Perks;
    public void Awake()
    {
       int perkpick = Random.Range(0, 21);
        Vector3 currLoc = GetComponent<Transform>().position;
        if(perkpick == 0)
        {
            Instantiate(Perks[0], currLoc, transform.rotation);
        }
        if (perkpick == 1)
        {
            Instantiate(Perks[1], currLoc, transform.rotation);

        }
        if (perkpick == 2)
        {
            Instantiate(Perks[2], currLoc, transform.rotation);

        }
        if (perkpick == 3)
        {
            Instantiate(Perks[3], currLoc, transform.rotation);

        }
        if (perkpick == 4)
        {
            Instantiate(Perks[4], currLoc, transform.rotation);

        }
        if (perkpick == 5)
        {
            Instantiate(Perks[5], currLoc, transform.rotation);

        }
        if (perkpick == 6)
        {
            Instantiate(Perks[6], currLoc, transform.rotation);

        }
        if (perkpick == 7)
        {
            Instantiate(Perks[7], currLoc, transform.rotation);

        }
        if (perkpick == 8)
        {
            Instantiate(Perks[8], currLoc, transform.rotation);

        }
        if (perkpick == 9)
        {
            Instantiate(Perks[9], currLoc, transform.rotation);

        }
        if (perkpick == 10)
        {
            Instantiate(Perks[10], currLoc, transform.rotation);

        }
        if (perkpick == 11)
        {
            Instantiate(Perks[11], currLoc, transform.rotation);

        }
        if (perkpick == 12)
        {
            Instantiate(Perks[12], currLoc, transform.rotation);

        }
        if (perkpick == 13)
        {
            Instantiate(Perks[13], currLoc, transform.rotation);

        }
        if (perkpick == 14)
        {
            Instantiate(Perks[14], currLoc, transform.rotation);

        }
        if (perkpick == 15)
        {
            Instantiate(Perks[15], currLoc, transform.rotation);

        }
        if (perkpick == 16)
        {
            Instantiate(Perks[16], currLoc, transform.rotation);

        }
        if (perkpick == 17)
        {
            Instantiate(Perks[17], currLoc, transform.rotation);

        }
        if (perkpick == 18)
        {
            Instantiate(Perks[18], currLoc, transform.rotation);

        }
        if (perkpick == 19)
        {
            Instantiate(Perks[19], currLoc, transform.rotation);

        }
        if (perkpick == 20)
        {
            Instantiate(Perks[20], currLoc, transform.rotation);

        }

    }
}

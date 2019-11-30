using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    PlayerManager pM;
    int currentHealthDisplay;
    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("DamageDealt");
            Debug.Log(pM.GetHealth());
            Debug.Log(currentHealthDisplay);
            damageDealt();
        }
    }
    public void damageDealt()
    {
        pM = SceneManager.Instance.GetPlayerManager();
        pM.SetHealth(-1);
    }
}

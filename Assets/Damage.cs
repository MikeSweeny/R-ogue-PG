using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    PlayerManager pM;
    public void Start()
    {
        pM = SceneManager.Instance.GetPlayerManager();
    }
    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            damageDealt();
        }
    }
    public void damageDealt()
    {
        Debug.Log("DamageDealt");
        pM.SetHealth(-1);
    }
}

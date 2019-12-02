using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Damage : MonoBehaviour
{
    private Collider myWeapon;
    // Start is called before the first frame update
    private void Awake()
    {
        myWeapon = GetComponent<BoxCollider>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "ModelPlayer_T-Pose")
        {
            Debug.Log("Hit");
        }
    }
}

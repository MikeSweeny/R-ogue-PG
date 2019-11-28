using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatistics : MonoBehaviour
{
    //create variables
    
     
    
    private string MyName;

    private float footsoldierBaseHealth = 100f;
    private float footsoldierBaseAttackSpeed = 3f;
    private float footsoldierBaseDamage = 20f;
    private float footsoldierBaseRange = 0.5f;

    private float knightBaseHealth = 300f;
    private float knightBaseAttackSpeed = 5f;
    private float knightBaseDamage = 40f;
    private float knightBaseRange = 0.8f;

    private float archerBaseHealth = 50f;
    private float archerBaseAttackSpeed = 4f;
    private float archerBaseDamage = 15f;
    private float archerBaseRange = 5f;

    private float health;
    private float attackSpeed;
    private float damage;
    private float range;

    private SphereCollider WeaponRange;



    // Start is called before the first frame update
    void Awake()
    {

        WeaponRange = gameObject.GetComponentInChildren<SphereCollider>();


        MyName = gameObject.name;

        if (MyName == "Enemy_Footsoldier(Clone)")
        {
            health = footsoldierBaseHealth;
            attackSpeed = footsoldierBaseAttackSpeed;
            damage = footsoldierBaseDamage;
            range = footsoldierBaseRange;

            WeaponRange.radius = range;

        }
        if (MyName == "Enemy_Knight(Clone)")
        {
            health = knightBaseHealth;
            attackSpeed = knightBaseAttackSpeed;
            damage = knightBaseDamage;
            range = knightBaseRange;

            WeaponRange.radius = range;

        }
        if (MyName == "Enemy_Archer(Clone)")
        {
            health = archerBaseHealth;
            attackSpeed = archerBaseAttackSpeed;
            damage = archerBaseDamage;
            range = archerBaseRange;

            WeaponRange.radius = range;
        }

        Debug.Log(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

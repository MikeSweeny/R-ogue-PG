using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatistics : MonoBehaviour
{
    //create variables
    
     
    
    private string MyName;

    public float footsoldierBaseHealth;
    public float footsoldierBaseAttackSpeed;
    public float footsoldierBaseDamage;
    public float footsoldierBaseRange;

    public float knightBaseHealth;
    public float knightBaseAttackSpeed;
    public float knightBaseDamage;
    public float knightBaseRange;

    public float archerBaseHealth;
    public float archerBaseAttackSpeed;
    public float archerBaseDamage;
    public float archerBaseRange;

    private float health;
    private float attackSpeed;
    private float damage;
    private float range;
    
    // Start is called before the first frame update
    void Awake()
    {
        MyName = gameObject.name;

        if (MyName == "Enemy_Footsoldier")
        {
            health = footsoldierBaseHealth;
            attackSpeed = footsoldierBaseAttackSpeed;
            damage = footsoldierBaseDamage;
            range = footsoldierBaseRange;
        }
        if (MyName == "Enemy_Knight")
        {
            health = knightBaseHealth;
            attackSpeed = knightBaseAttackSpeed;
            damage = knightBaseDamage;
            range = knightBaseRange;
        }
        if (MyName == "Enemy_Archer")
        {
            health = archerBaseHealth;
            attackSpeed = archerBaseAttackSpeed;
            damage = archerBaseDamage;
            range = archerBaseRange;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

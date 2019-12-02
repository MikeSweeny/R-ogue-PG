using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private Collider spawnArea;
    private Vector3 spawnAreaSize;
    private Vector3 spawnPoint;
    private Vector3 size;


    // Start is called before the first frame update
    void Start()
    {
        //get the collider fromt he attached object
        spawnArea = GetComponent<Collider>();

        //Get the collider's size
        spawnAreaSize = spawnArea.bounds.size;

        // LOOK AT THIS COMMENT !!!      ***   delete this function call when we're done testing   ***
        Spawn();
    }

    // Update is called once per frame

    private void Spawn()
    {
        //this gets the objects from the enemy pool, moves them and then actives them while there are still objects in the pool
        do
        {
            GameObject Enemy = EnemyPool.SharedInstance.GetPooledObject();

            //get position based off of the size of the collider
            Vector3 pos = new Vector3(Random.Range(this.transform.position.x - spawnAreaSize.x / 2, this.transform.position.x + spawnAreaSize.x / 2), this.transform.position.y, Random.Range(this.transform.position.z - spawnAreaSize.z /2, this.transform.position.z + spawnAreaSize.z / 2));
            
            //Move the enemy to the position vector
            Enemy.transform.position = pos;

            //set the enemy to active so that they are spawned
            Enemy.SetActive(true);

        }while (EnemyPool.SharedInstance.GetPooledObject() != null) ;
    }

    public void SpawnWave(int round, int wave)
    {

    }

}

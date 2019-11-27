using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private GameObject spawnArea;
    private Vector3 center;
    private Vector3 size;
    // Start is called before the first frame update
    void Start()
    {
        //get the ground object on the Spawn Area object
        spawnArea = GameObject.Find("SpawnArea/Ground");

        //Put the center of the spawner in the center of the Ground
        center = new Vector3(spawnArea.transform.position.x / 2, spawnArea.transform.position.y / 2, spawnArea.transform.position.z / 2);
        // This is the size of the area we are spawning inside (it is set to the size of the Ground Object
        //size = new Vector3(spawnArea.GetComponent<Transform>().transform.position.x, spawnArea.GetComponent<Transform>().transform.position.y, spawnArea.GetComponent<Transform>().transform.position.z);

        Spawn();
    }

    // Update is called once per frame

    private void Spawn()
    {
         //Define the EnemyPooler as GameObject Enemy, passing in the ShipName from the RandomShip Switch statement

        for (int i = 0; i >= 10; i++)
        {        
            GameObject Enemy = EnemyPool.SharedInstance.GetPooledObject();

            Vector3 pos = center;// + new Vector3(Random.Range(-spawnArea.GetComponent<Transform>().transform.position.x / 2, spawnArea.GetComponent<Transform>().transform.position.x / 25), Random.Range(-spawnArea.GetComponent<Transform>().transform.position.y / 2, spawnArea.GetComponent<Transform>().transform.position.y / 2), Random.Range(-spawnArea.GetComponent<Transform>().transform.position.z / 2, spawnArea.GetComponent<Transform>().transform.position.z / 2));

            //Move the enemy to the position vector
            Enemy.transform.position = pos;

            //set the enemy to active so that they are spawned
            Enemy.SetActive(true);
        }
        
    }

}

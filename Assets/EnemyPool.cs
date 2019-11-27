using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    //Allows other scripts to acces this without getting a component from a GameObject
    public static EnemyPool SharedInstance;

    //Create a list of Game Objects called enemyObjects
    private List<GameObject> enemeyObjects;
    //Create a list of Game Objects to store the enemy types
    public  List<GameObject> enemyTypes;
    //create an array of game objects that are then added to the enemyObjects List
    private GameObject[] objectToPool;
    //This variable represents how many objects are in the enemyObjects List
    private int amountToPool = 1;
    private int randomEnemyType;

    //The object we want to add to object pool
    private GameObject obj;

    //This variable represents how large the wave is supposed to be
    public int waveSize;

    private void Awake()
    {
        SharedInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        enemeyObjects = new List<GameObject>();

        for (int i = 0; i < amountToPool; i++)
        {
            //increase the size of the pool if it is less than the amount desired in the wave
            if (amountToPool <= waveSize)
            {
                amountToPool++;
            }
            //Create for loop that instantiates the objectToPool the specified number of times declared in numberToPool
            
            if (randomEnemyType <= 6)
            {
                obj = (GameObject)Instantiate(enemyTypes[0]);

            }
            else if (randomEnemyType > 6 && randomEnemyType <= 8)
            {
                obj = (GameObject)Instantiate(enemyTypes[1]);

            }
            else
            {
                obj = (GameObject)Instantiate(enemyTypes[2]);

            }
            //Set all gameobjects to an inactive state
            obj.SetActive(true);

            

            //Add the now inactive gameobject to the enemyObjects List
            enemeyObjects.Add(obj);
            
        }
    }
    //Since this function 
    public GameObject GetPooledObject(string Tag)
    {
        //Create for loop to iterate throuh the enemyObjects List
        for (int i = 0; i < enemeyObjects.Count; i++)
        {
            //If the object is active, it progresses to the next object in the List, if not exit the method
            if (!enemeyObjects[i].activeInHierarchy && enemeyObjects[i].name == Tag)
            {
                return enemeyObjects[i];
            }
        }
        //If there is no currently active objects, exit and return nothing
        return null;
    }
    // Update is called once per frame
    void Update()
    {
        randomEnemyType = Random.Range(0, 10);
    }
}

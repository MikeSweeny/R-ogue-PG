using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePool : MonoBehaviour
{
    public List<GameObject> projectiles;

    public GameObject prefab_Projectile;
    int poolStartSize = 20;
    Vector3 poolStartLoc = new Vector3(0, -100, 0);

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PopulatePool()
    {
        for (int i = 0; i < poolStartSize; i++)
        {
            GameObject obj;
            obj = Instantiate(prefab_Projectile);
            obj.SetActive(false);
            obj.transform.position = poolStartLoc;
            projectiles.Add(obj);
        }
    }

    public GameObject FetchObjectFromPool()
    {
        for (int i = 0; i < projectiles.Count; i++)
        {
            if (projectiles[i].activeSelf == false)
            {
                return projectiles[i];
            }
        }
        return AddToPool();
    }

    private GameObject AddToPool()
    {
        GameObject obj;
        obj = Instantiate(prefab_Projectile);
        obj.SetActive(false);
        projectiles.Add(obj);
        return obj;
    }
}

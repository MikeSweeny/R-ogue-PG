using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    EnemyPool pool;
    int poolSize;
    EnemySpawner gameSpawner;
    public DoorLever doorLever;
    public bool waveActive;

    public static int roundNum, waveNum, waveCountPerRound;
    private float waveCD, waveTimer;

    private int enemyWaveModifier, enemyRoundModifier;

    // Start is called before the first frame update
    void Start()
    {
        roundNum = 1;
        waveNum = 0;
        waveCountPerRound = 5;
        waveCD = 5f;
        waveTimer = 0f;

        enemyRoundModifier = 1;
        enemyWaveModifier = 2;
        pool = EnemyPool.SharedInstance;
        gameSpawner = GetComponent<EnemySpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waveActive)
        {
            CheckWaveCompleteStatus();
            waveTimer += Time.deltaTime;
            if (waveTimer >= waveCD)
            {
                waveTimer = 0;
                waveNum++;
                if (waveNum == 5)
                {
                    SpawnWave(roundNum, waveNum);
                    roundNum++;
                    waveNum = 1;
                }
            }
        }     
    }


    public bool CheckWaveCompleteStatus()
    {
        for (int i = 0; i < pool.enemyObjects.Count; i++)
        {
            if (pool.enemyObjects[i].activeSelf)
            {
                waveActive = false;
                return waveActive;
            }
            else
            {
                waveActive = true;
                return waveActive;
            }
        }
        waveActive = true;
        return waveActive;
    }

    private void SpawnWave(int round, int wave)
    {
        poolSize = (round * enemyRoundModifier) + (wave * enemyWaveModifier);
        pool.CreatePool(poolSize);
        gameSpawner.Spawn();
    }

    private bool CheckLeverStatus()
    {
        return doorLever.isOn;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    EnemyPool pool;
    EnemySpawner gameSpawner;

    public static bool playerHasHitLever;
    public static bool roundComplete;
    public static bool waveComplete;
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
        CheckWaveCompleteStatus();
        if (playerHasHitLever)
        {
            if (waveComplete)
            {
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
    }


    public bool CheckWaveCompleteStatus()
    {
        for (int i = 0; i < pool.enemyObjects.Count; i++)
        {
            if (pool.enemyObjects[i].activeSelf)
            {
                waveComplete = false;
                return waveComplete;
            }
            else
            {
                waveComplete = true;
                return waveComplete;
            }
        }
        waveComplete = true;
        return waveComplete;
    }

    private void SpawnWave(int round, int wave)
    {
        gameSpawner.SpawnWave(round, wave);
    }
}

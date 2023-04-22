using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public GameObject canvas;
    public Text waveCounter;
    float timeToSpawn = 6f;
    float lastSpawned = 0;
    float enemiesDefeated = 0;
    float enemiesSpawned = 0;
    float enemyLimit = 3;
    int waves = 1;
    int reachedWaveNumber = 4;
    bool ableToSpawn = true;
    public bool upgrades1 = true;
    public bool upgrades2 = true;
    public bool upgrades3 = true;
    ScoreManager scoreManager;
    void Start()
    {
        scoreManager = canvas.GetComponent<ScoreManager>();
        ableToSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {

        waveCounter.text = waves.ToString();
        if (Time.time > lastSpawned + timeToSpawn && enemiesSpawned < enemyLimit && ableToSpawn)
        {
            lastSpawned = Time.time;
            GameObject enemySpawned = Instantiate(enemy, transform.position, transform.rotation);
            enemiesSpawned++;
            print("enemies spawned: " + enemiesSpawned);
        }

        if (enemiesDefeated >= enemyLimit * 2)
        {
            enemiesDefeated = 0;
            enemiesSpawned = 0;
            enemyLimit = enemyLimit + 1;
            timeToSpawn = timeToSpawn - (1f * 1.5f/waves);
            waves++;
            print("wave number " + waves);
        }

        if (waves == 4 && reachedWaveNumber == 4)
        {
            ableToSpawn = false;
            if (upgrades1)
            {
                scoreManager.RoundEnded();
                upgrades1 = false;
            }
            
        }

        if (waves == 7 && reachedWaveNumber == 7)
        {
            ableToSpawn = false;
            if (upgrades2)
            {
                scoreManager.RoundEnded();
                upgrades2 = false;
            }

        }

        if (waves == 10 && reachedWaveNumber == 10)
        {
            ableToSpawn = false;
            if (upgrades3)
            {
                scoreManager.RoundEnded();
                upgrades3 = false;
            }

        }

    }

    public void DefeatedEnemy()
    {
        enemiesDefeated++;
        print(enemiesDefeated);
    }

    public void ResetTime()
    {
        ableToSpawn = true;
        reachedWaveNumber = reachedWaveNumber + 3;
        //waves++;
        //upgrades = true;
    }

    public void IncreaseWaves()
    {
        waves = waves;
    }
}

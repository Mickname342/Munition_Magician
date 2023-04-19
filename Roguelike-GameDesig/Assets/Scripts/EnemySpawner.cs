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
    bool ableToSpawn = true;
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
            //print(enemiesSpawned);
        }

        if (enemiesDefeated >= enemyLimit * 2)
        {
            enemiesDefeated = 0;
            enemiesSpawned = 0;
            enemyLimit = enemyLimit + 1;
            timeToSpawn = timeToSpawn - 0.5f;
            waves++;
            print("wave number " + waves);
        }

        if (waves == 2)
        {
            scoreManager.RoundEnded();
            ableToSpawn = false;
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
    }

    public void IncreaseWaves()
    {
        waves++;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public GameObject canvas;
    public Text waveCounter;
    float timeToSpawn = 6.5f;
    float lastSpawned = 0;
    float enemiesDefeated = 0;
    float enemiesSpawned = 0;
    float enemyLimit = 3;
    float enemiesOnField = 0;
    int waves = 1;
    int reachedWaveNumber = 4;
    bool ableToSpawn = true;
    public bool upgrades1 = true;
    public bool upgrades2 = true;
    public bool upgrades3 = true;
    public bool shooting = false;
    ScoreManager scoreManager;


    EnemySpawner enemySpawner1;
    EnemySpawner enemySpawner2;
    EnemySpawner enemySpawner3;
    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;
    void Start()
    {
        scoreManager = canvas.GetComponent<ScoreManager>();
        ableToSpawn = true;
        enemySpawner1 = spawner1.GetComponent<EnemySpawner>();
        enemySpawner2 = spawner2.GetComponent<EnemySpawner>();
        enemySpawner3 = spawner3.GetComponent<EnemySpawner>();
    }

    // Update is called once per frame
    void Update()
    {

        waveCounter.text = waves.ToString();
        if (Time.time > lastSpawned + timeToSpawn && enemiesSpawned < enemyLimit && ableToSpawn)
        {
            lastSpawned = Time.time;
            GameObject enemySpawned = Instantiate(enemy, transform.position + new Vector3(0,0,-3), transform.rotation);
            enemiesSpawned++;
            enemySpawner1.MoreEnemiesOnField();
            enemySpawner2.MoreEnemiesOnField();
            enemySpawner3.MoreEnemiesOnField();
            if (shooting)
            {
                timeToSpawn = 999;
            }
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

        if (waves == 4 && reachedWaveNumber == 4 )
        {
            ableToSpawn = false;
            if (upgrades1 && enemiesOnField <= 0)
            {
                scoreManager.RoundEnded();
                upgrades1 = false;
            }
            
        }

        if (waves == 7 && reachedWaveNumber == 7 )
        {
            ableToSpawn = false;
            if (upgrades2 && enemiesOnField <= 0)
            {
                scoreManager.RoundEnded();
                upgrades2 = false;
            }

        }

        if (waves == 10 && reachedWaveNumber == 10 )
        {
            ableToSpawn = false;
            if (upgrades3 && enemiesOnField <= 0)
            {
                scoreManager.RoundEnded();
                upgrades3 = false;
            }

        }

        if (waves == 11 && enemiesOnField == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void DefeatedEnemy()
    {
        enemiesDefeated++;
        enemiesOnField--;
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

    public void SpawnShooter()
    {
        lastSpawned = Time.time;
        timeToSpawn = 6;
    }

    public void MoreEnemiesOnField()
    {
        enemiesOnField++;
        print("enemies onField: " + enemiesOnField);
    }
}

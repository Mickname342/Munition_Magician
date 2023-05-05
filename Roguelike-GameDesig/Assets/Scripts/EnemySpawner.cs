using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public GameObject bigEnemy;
    public GameObject canvas;
    public Text waveCounter;
    float timeToSpawn = 6.5f;
    float lastSpawned = 0;
    float enemiesDefeated = 0;
    float enemiesSpawned = 0;
    public float enemyLimit = 3;
    float enemiesOnField = 0;
    public int waves = 1;
    public int reachedWaveNumber = 1;
    public bool ableToSpawn = false;
    public bool upgrades1 = true;
    public bool upgrades2 = true;
    public bool upgrades3 = true;
    public bool shooting = false;
    ScoreManager scoreManager;
    
    public bool wave2 = false;
    public bool wave3 = false;
    public bool wave5 = false;
    public bool wave6 = false;
    public bool wave8 = false;
    public bool wave9 = false;
    public bool wave11 = false;
    public bool wave12 = false;


    EnemySpawner enemySpawner1;
    EnemySpawner enemySpawner2;
    EnemySpawner enemySpawner3;
    EnemySpawner enemySpawner4;
    EnemySpawner enemySpawner5;
    EnemySpawner enemySpawner6;
    EnemySpawner enemySpawner7;
    EnemySpawner enemySpawner8;
    EnemySpawner enemySpawner9;
    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;
    public GameObject spawner4;
    public GameObject spawner5;
    public GameObject spawner6;
    public GameObject spawner7;
    public GameObject spawner8;
    public GameObject spawner9;
    void Start()
    {
        scoreManager = canvas.GetComponent<ScoreManager>();
        //ableToSpawn = false;
        enemySpawner1 = spawner1.GetComponent<EnemySpawner>();
        enemySpawner2 = spawner2.GetComponent<EnemySpawner>();
        enemySpawner3 = spawner3.GetComponent<EnemySpawner>();
        enemySpawner4 = spawner4.GetComponent<EnemySpawner>();
        enemySpawner5 = spawner5.GetComponent<EnemySpawner>();
        enemySpawner6 = spawner6.GetComponent<EnemySpawner>();
        enemySpawner7 = spawner7.GetComponent<EnemySpawner>();
        enemySpawner8 = spawner8.GetComponent<EnemySpawner>();
        enemySpawner9 = spawner9.GetComponent<EnemySpawner>();
        waveCounter.text = 1.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        if (enemiesOnField <= 0)
        {
            enemiesOnField = 0;
        }
        //waveCounter.text = waves.ToString();
        if (Time.time > lastSpawned + timeToSpawn && enemiesSpawned < enemyLimit && ableToSpawn)
        {
            lastSpawned = Time.time;
            GameObject enemySpawned = Instantiate(enemy, transform.position + new Vector3(0,0,-3), transform.rotation);
            enemiesSpawned++;
            enemySpawner1.MoreEnemiesOnField();
            enemySpawner2.MoreEnemiesOnField();
            enemySpawner3.MoreEnemiesOnField();
            enemySpawner4.MoreEnemiesOnField();
            enemySpawner5.MoreEnemiesOnField();
            enemySpawner6.MoreEnemiesOnField();
            enemySpawner7.MoreEnemiesOnField();
            enemySpawner8.MoreEnemiesOnField();
            enemySpawner9.MoreEnemiesOnField();
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
            timeToSpawn = timeToSpawn - 1/waves;
            waves++;
            print("wave number " + waves);
        }

        if( waves == 2 && wave2 == false)
        {
            if (enemiesOnField > 0)
            {
                ableToSpawn = false;
            }
            else if (enemiesOnField <= 0)
            {
                ableToSpawn = true;
                wave2 = true;
                waveCounter.text = waves.ToString();
                enemiesDefeated = 0;
                enemiesSpawned = 0;
            }
        }
        if (waves == 3 && wave3 == false)
        {
            if (enemiesOnField > 0)
            {
                ableToSpawn = false;
            }
            else if (enemiesOnField <= 0)
            {
                ableToSpawn = true;
                wave3 = true;
                waveCounter.text = waves.ToString();
                enemiesDefeated = 0;
                enemiesSpawned = 0;
            }
        }
        if (waves == 5 && wave5 == false)
        {
            if (enemiesOnField > 0)
            {
                ableToSpawn = false;
            }
            else if (enemiesOnField <= 0)
            {
                ableToSpawn = true;
                wave5 = true;
                waveCounter.text = waves.ToString();
                enemiesDefeated = 0;
                enemiesSpawned = 0;
            }
        }
        if (waves == 6 && wave6 == false)
        {
            if (enemiesOnField > 0)
            {
                ableToSpawn = false;
            }
            else if (enemiesOnField <= 0)
            {
                ableToSpawn = true;
                wave6 = true;
                waveCounter.text = waves.ToString();
                enemiesDefeated = 0;
                enemiesSpawned = 0;
            }
        }
        if (waves == 8 && wave8 == false)
        {
            if (enemiesOnField > 0)
            {
                ableToSpawn = false;
            }
            else if (enemiesOnField <= 0)
            {
                ableToSpawn = true;
                wave8 = true;
                waveCounter.text = waves.ToString();
                enemiesDefeated = 0;
                enemiesSpawned = 0;
            }
        }

        if (waves == 9 && wave9 == false)
        {
            if (enemiesOnField > 0)
            {
                ableToSpawn = false;
            }
            else if (enemiesOnField <= 0)
            {
                ableToSpawn = true;
                wave9 = true;
                waveCounter.text = waves.ToString();
                enemiesDefeated = 0;
                enemiesSpawned = 0;
            }
        }
        
        if (waves == 11 && wave11 == false)
        {
            if (enemiesOnField > 0)
            {
                ableToSpawn = false;
            }
            else if (enemiesOnField <= 0)
            {
                ableToSpawn = true;
                wave11 = true;
                waveCounter.text = waves.ToString();
                enemiesDefeated = 0;
                enemiesSpawned = 0;
            }
        }
        if (waves == 12 && wave12 == false)
        {
            if (enemiesOnField > 0)
            {
                ableToSpawn = false;
            }
            else if (enemiesOnField <= 0)
            {
                ableToSpawn = true;
                wave12 = true;
                waveCounter.text = waves.ToString();
                enemiesDefeated = 0;
                enemiesSpawned = 0;
            }
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

        if (waves >= 13)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void DefeatedEnemy()
    {
        enemiesDefeated++;
        enemiesOnField--;
        print("you defeated: " + enemiesDefeated);
    }

    public void ResetTime()
    {
        ableToSpawn = true;
        reachedWaveNumber = reachedWaveNumber + 3;
        print("i've reached wave nº: " + reachedWaveNumber);
        waveCounter.text = waves.ToString();
        enemiesDefeated = 0;
        enemiesSpawned = 0;
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

    public void ChangeEnemy()
    {
        enemy = bigEnemy;
    }
}

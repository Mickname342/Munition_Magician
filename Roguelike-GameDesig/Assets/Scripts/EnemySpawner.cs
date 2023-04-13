using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    float timeToSpawn = 6f;
    float lastSpawned = 0;
    float enemiesDefeated = 0;
    float enemiesSpawned = 0;
    float enemyLimit = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > lastSpawned + timeToSpawn && enemiesSpawned < enemyLimit)
        {
            lastSpawned = Time.time;
            GameObject enemySpawned = Instantiate(enemy, transform.position, transform.rotation);
            enemiesSpawned++;
            print(enemiesSpawned);
        }

        if (enemiesDefeated >= enemyLimit * 2)
        {
            enemiesDefeated = 0;
            enemiesSpawned = 0;
            enemyLimit = enemyLimit + 1;
            timeToSpawn = timeToSpawn - 0.5f;
        }
    }

    public void DefeatedEnemy()
    {
        enemiesDefeated++;
        print(enemiesDefeated);
    }
}

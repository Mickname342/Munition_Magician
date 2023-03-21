using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    float timeToSpawn = 6f;
    float lastSpawned = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > lastSpawned + timeToSpawn)
        {
            lastSpawned = Time.time;
            GameObject enemySpawned = Instantiate(enemy, transform.position, transform.rotation);
        }
    }
}

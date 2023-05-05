using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public GameObject shooterSpawner1;
    public GameObject shooterSpawner2;
    public GameObject normalSpawner1;
    public GameObject normalSpawner2;
    public GameObject normalSpawner3;
    public GameObject normalSpawner4;
    public GameObject normalSpawner5;
    public GameObject normalSpawner6;
    public GameObject normalSpawner7;
    public GameObject normalSpawner8;
    public GameObject normalSpawner9;
    public GameObject wall1;
    public GameObject wall2;

    public EnemySpawner enemySpawner1;
    public EnemySpawner enemySpawner2;
    public EnemySpawner enemySpawner3;
    public EnemySpawner enemySpawner4;
    public EnemySpawner enemySpawner5;
    public EnemySpawner enemySpawner6;
    public EnemySpawner enemySpawner7;
    public EnemySpawner enemySpawner8;
    public EnemySpawner enemySpawner9;


    int timesActivated = 0;
    // Start is called before the first frame update
    void Start()
    {
        enemySpawner1 = normalSpawner1.GetComponent<EnemySpawner>();
        enemySpawner2 = normalSpawner2.GetComponent<EnemySpawner>();
        enemySpawner3 = normalSpawner3.GetComponent<EnemySpawner>();
        enemySpawner4 = normalSpawner4.GetComponent<EnemySpawner>();
        enemySpawner5 = normalSpawner5.GetComponent<EnemySpawner>();
        enemySpawner6 = normalSpawner6.GetComponent<EnemySpawner>();
        enemySpawner7 = normalSpawner7.GetComponent<EnemySpawner>();
        enemySpawner8 = normalSpawner8.GetComponent<EnemySpawner>();
        enemySpawner9 = normalSpawner9.GetComponent<EnemySpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timesActivated == 2)
        {
            shooterSpawner1.SetActive(true);
            normalSpawner1.SetActive(true);
            normalSpawner2.SetActive(true);
            wall1.SetActive(false);
        }
        if (timesActivated == 3)
        {
            shooterSpawner2.SetActive(true);
            normalSpawner4.SetActive(true);
            normalSpawner3.SetActive(true);
            wall2.SetActive(false);
        }
        if (timesActivated == 4)
        {
            enemySpawner8.ChangeEnemy();
            enemySpawner9.ChangeEnemy();
            enemySpawner3.ChangeEnemy();
            enemySpawner4.ChangeEnemy();
        }
    }

    public void AddTimesActivated()
    {
        timesActivated++;
    }
}

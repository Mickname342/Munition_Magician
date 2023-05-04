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
    public GameObject wall1;
    public GameObject wall2;

    int timesActivated = 0;
    // Start is called before the first frame update
    void Start()
    {
        
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
    }

    public void AddTimesActivated()
    {
        timesActivated++;
    }
}

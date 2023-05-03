using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public GameObject shooterSpawner1;
    public GameObject shooterSpawner2;

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
            shooterSpawner2.SetActive(true);
        }
    }

    public void AddTimesActivated()
    {
        timesActivated++;
    }
}

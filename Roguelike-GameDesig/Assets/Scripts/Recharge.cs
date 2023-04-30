using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recharge : MonoBehaviour
{
    Shooting shoot;
    public GameObject shooter;
    // Start is called before the first frame update
    void Start()
    {
        shoot = shooter.GetComponent<Shooting>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Recharged()
    {
        shoot.Recharge();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float timeSaved;
    float timeLimit = 0.8f;
    public bool enemy = false;

    private void Start()
    {
        timeSaved = Time.time;
    }

    private void Update()
    {
        if (Time.time >= timeSaved + timeLimit && enemy)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Wind"))
        {
            Destroy(gameObject);
        }
       
    }

    public void AddFire()
    {
        gameObject.AddComponent<ApplyFire>();
    }

    public void AddWater()
    {
        gameObject.AddComponent<ApplyWater>();
    }

    public void AddElectricity()
    {
        gameObject.AddComponent<ApplyElectricity>();
    }

    public void AddWind()
    {
        Rigidbody2D body = GetComponent<Rigidbody2D>();
        body.mass = 999;
    }
}

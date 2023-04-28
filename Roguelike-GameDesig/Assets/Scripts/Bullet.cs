using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float timeSaved;
    float timeLimit = 0.8f;

    private void Start()
    {
        timeSaved = Time.time;
    }

    private void Update()
    {
        if (Time.time >= timeSaved + timeLimit)
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
}

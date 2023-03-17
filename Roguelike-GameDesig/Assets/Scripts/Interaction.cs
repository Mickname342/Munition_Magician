using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interaction : MonoBehaviour
{
    public UnityEvent interact;
    private void OnTriggerEnter2D(Collider2D other)
    {
        //interact.Invoke();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            interact.Invoke();
        }
        
    }
}

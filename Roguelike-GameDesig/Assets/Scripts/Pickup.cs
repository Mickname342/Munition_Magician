using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pickup : MonoBehaviour
{
    public UnityEvent interact;
    Shooting shooting;
    public GameObject player;

    private void Start()
    {
        shooting = player.GetComponent<Shooting>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            interact.Invoke();
            shooting.ReloadBombs();
            Destroy(gameObject);
        }
           

    }
}

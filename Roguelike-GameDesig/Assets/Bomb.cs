using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject explosion;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fire") || collision.gameObject.CompareTag("DoubleDamage"))
        {
            GameObject exploding = Instantiate(explosion,transform.position,transform.rotation);
            Destroy(gameObject);
        }
        
    }
}

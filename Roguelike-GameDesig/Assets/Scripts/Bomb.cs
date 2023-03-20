using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject explosion;
    public GameObject wind;
    public GameObject barrier;
    public GameObject waterStream;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fire") || collision.gameObject.CompareTag("DoubleDamage"))
        {
            GameObject exploding = Instantiate(explosion,transform.position,transform.rotation);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Wind"))
        {
            GameObject wind1 = Instantiate(wind, transform.position, transform.rotation);
            GameObject wind2 = Instantiate(wind, transform.position, transform.rotation);
            GameObject wind3 = Instantiate(wind, transform.position, transform.rotation);
            Rigidbody2D wb1 = wind1.GetComponent<Rigidbody2D>();
            wb1.AddForce(transform.right * 10, ForceMode2D.Impulse);
            wb1.AddForce(transform.up * 10, ForceMode2D.Impulse);
            Rigidbody2D wb2 = wind2.GetComponent<Rigidbody2D>();
            wb2.AddForce(transform.right * 10, ForceMode2D.Impulse);
            Rigidbody2D wb3 = wind3.GetComponent<Rigidbody2D>();
            wb3.AddForce(transform.right * 10, ForceMode2D.Impulse);
            wb3.AddForce(transform.up * -10, ForceMode2D.Impulse);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("GroundBullet"))
        {
            GameObject barrier1 = Instantiate(barrier, transform.position, transform.rotation * Quaternion.Euler(0,0,90));
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Water"))
        {
            GameObject waterStream1 = Instantiate(waterStream, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}

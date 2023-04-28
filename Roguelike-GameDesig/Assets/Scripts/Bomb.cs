using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject explosion;
    public GameObject wind;
    public GameObject elctricity;
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
            GameObject wind4 = Instantiate(wind, transform.position,transform.rotation);
            Rigidbody2D wb1 = wind1.GetComponent<Rigidbody2D>();
            wb1.AddForce(transform.right * 10 * 999 * 3, ForceMode2D.Impulse);
            wb1.AddForce(transform.up * 2 * 999 * 3, ForceMode2D.Impulse);
            Rigidbody2D wb2 = wind2.GetComponent<Rigidbody2D>();
            wb2.AddForce(transform.right * 11 * 999 * 3, ForceMode2D.Impulse);
            wb2.AddForce(transform.up * 0.5f * 999 * 3, ForceMode2D.Impulse);
            Rigidbody2D wb4 = wind4.GetComponent<Rigidbody2D>();
            wb4.AddForce(transform.right * 11 * 999 * 3, ForceMode2D.Impulse);
            wb4.AddForce(transform.up * -0.5f * 999 * 3, ForceMode2D.Impulse);
            Rigidbody2D wb3 = wind3.GetComponent<Rigidbody2D>();
            wb3.AddForce(transform.right * 10 * 999 * 3, ForceMode2D.Impulse);
            wb3.AddForce(transform.up * -2 * 999 * 3, ForceMode2D.Impulse);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("GroundBullet"))
        {
            GameObject electricity1 = Instantiate(elctricity, transform.position + new Vector3(-1.5f, -1.5f,0), transform.rotation);
            GameObject electricity2 = Instantiate(elctricity, transform.position + new Vector3(1.5f, -1.5f,0), transform.rotation);
            GameObject electricity3 = Instantiate(elctricity, transform.position + new Vector3(0, 1.5f,0), transform.rotation);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Water"))
        {
            GameObject waterStream1 = Instantiate(waterStream, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}

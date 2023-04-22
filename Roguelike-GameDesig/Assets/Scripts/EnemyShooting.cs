using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    float delayBetweenShots = 3;
    float timeLastShot;
    public GameObject enemyBullet;
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        timeLastShot = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > delayBetweenShots + timeLastShot)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        timeLastShot = Time.time;
        float angle = Mathf.Atan2(playerTransform.position.y - transform.position.y, playerTransform.position.x - transform.position.x) * Mathf.Rad2Deg;
        print(angle);
        GameObject bulletShot = Instantiate(enemyBullet, transform.position, Quaternion.Euler(0, 0, angle));
        Rigidbody2D rb = bulletShot.GetComponent<Rigidbody2D>();
        float xcomponent = Mathf.Cos(angle * Mathf.PI / 180) * 10;
        float ycomponent = Mathf.Sin(angle * Mathf.PI / 180) * 10;
        Vector3 forceapplied = new Vector3(xcomponent, ycomponent, 0);
        print(forceapplied);
        rb.AddForce(forceapplied, ForceMode2D.Impulse);
    }
}

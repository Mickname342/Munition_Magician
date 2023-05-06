using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    float delayBetweenShots = 3;
    float timeLastShot;
    public GameObject enemyBullet;
    public Transform playerTransform;
    public Transform shootingBar;
    public Transform Enemy;
    public Transform spriteGoblin;
    public AudioSource shoot;
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

        shootingBar.localScale = new Vector3(timeLastShot + delayBetweenShots - Time.time,1,1);
        shootingBar.position = new Vector3(Enemy.position.x-1 + (timeLastShot + delayBetweenShots - Time.time)*0.35f, Enemy.position.y + 2.72f, 0);

    }

    public void Shoot()
    {
        timeLastShot = Time.time;
        shoot.Play();
        float angle = Mathf.Atan2(playerTransform.position.y - transform.position.y, playerTransform.position.x - transform.position.x) * Mathf.Rad2Deg;
        print(angle);
        GameObject bulletShot = Instantiate(enemyBullet, transform.position, Quaternion.Euler(0, 0, angle));
        Rigidbody2D rb = bulletShot.GetComponent<Rigidbody2D>();
        float xcomponent = Mathf.Cos(angle * Mathf.PI / 180) * 10;
        float ycomponent = Mathf.Sin(angle * Mathf.PI / 180) * 10;
        Vector3 forceapplied = new Vector3(xcomponent, ycomponent, 0);
        print(forceapplied);
        rb.AddForce(forceapplied * 4, ForceMode2D.Impulse);
    }
}

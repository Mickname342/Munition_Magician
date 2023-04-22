using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject fireBullet;
    public GameObject waterBullet;
    public GameObject windBullet;
    public GameObject groundBullet;
    public GameObject bomb;
    public GameObject upgradeMenu;
    GameObject bulletPrefab;
    GameObject bulletPrefab2;
    //public AudioSource shoot;
    public UnityEvent bulletsDown;
    public UnityEvent reload;

    public float bulletforce = 20f;
    float timeLastShot = 0f;
    float delayBetweenShots = 0.35f;
    float timeLastBullet = 0f;
    int currentBombs = 5;
    int bombLimit = 5;
    int currentBullets = 1;
    float initialAngle = 0f;
    bool fire = true;
    bool water = false;

    // Update is called once per frame
    private void Start()
    {
        bulletPrefab = fireBullet;
        bulletPrefab2 = waterBullet;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1) && Time.time > timeLastBullet + delayBetweenShots && currentBombs > 0)
        {
            ShootSpecial();
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            fire = !fire;
            reload.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            MoreBombs();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            MoreBullets();
        }

    }

    void Shoot()
    {
        if (fire)
        {
            //shoot.Play();
            timeLastBullet = Time.time;
            for(int i = 0; i < currentBullets; i++)
            {
                GameObject bullet2 = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
                Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>();
                float horizontalForce = Mathf.Cos(initialAngle*(i-2));
                float verticalForce = Mathf.Sin(initialAngle * (i - 2));
                rb2.AddForce(firepoint.right * bulletforce *horizontalForce , ForceMode2D.Impulse);
                rb2.AddForce(firepoint.up * bulletforce * verticalForce , ForceMode2D.Impulse);
            }
            
        }
        else
        {
            //shoot.Play();
            timeLastBullet = Time.time;
            GameObject bullet = Instantiate(bulletPrefab2, firepoint.position, firepoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firepoint.right * bulletforce, ForceMode2D.Impulse);
        }
        //bullets--;
        //bulletsDown.Invoke();

    }

    void ShootSpecial()
    {
        //shoot.Play();
        timeLastBullet = Time.time;
        GameObject bullet = Instantiate(bomb, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        currentBombs--;
        print("bombs Left: " + currentBombs);
        
    }

    public void firePrimary()
    {
        bulletPrefab = fireBullet;
    }
    public void waterPrimary()
    {
        bulletPrefab = waterBullet;
    }
    public void windPrimary()
    {
        bulletPrefab = windBullet;
    }
    public void groundPrimary()
    {
        bulletPrefab = groundBullet;
    }
    public void fireSecondary()
    {
        bulletPrefab2 = fireBullet;
    }
    public void waterSecondary()
    {
        bulletPrefab2 = waterBullet;
    }
    public void windSecondary()
    {
        bulletPrefab2 = windBullet;
    }
    public void groundSecondary()
    {
        bulletPrefab2 = groundBullet;
    }

    public void ReloadBombs()
    {
        currentBombs = currentBombs + 2;
        if(currentBombs > bombLimit)
        {
            currentBombs = bombLimit;
        }
    }

    public void MoreBombs()
    {
        bombLimit = bombLimit +2;
    }

    public void MoreBullets()
    {
        upgradeMenu.SetActive(false);
        currentBullets = currentBullets + 1;
        initialAngle = initialAngle + 0.1f;
    }

    public void MoreSpeed()
    {
        bulletforce = bulletforce + 10f;
    }
}

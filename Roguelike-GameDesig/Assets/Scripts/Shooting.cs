using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

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
    public GameObject weaponChanger;
    public Text bombNumber;
    public Text bombTotalNumber;
    public Text bulletNumber;
    public Text bulletTotalNumber;

    public Transform rechargeBar;
    public SpriteRenderer rechargeSprite;
    public Animator rechargeAnim;


    public float bulletforce = 40f;
    float timeLastShot = 0f;
    float delayBetweenShots = 0.07f;
    float timeLastBullet = 0f;
    int currentBombs = 5;
    int bombLimit = 5;
    int currentBullets = 1;
    float initialAngle = 0f;
    bool fire = true;
    bool water = false;
    
    int bullets = 60;
    int totalBullets = 60;
    float rechargeTime = 2f;
    float rechargeStart = 0f;
    bool recharging = false;

    // Update is called once per frame
    private void Start()
    {
        bulletPrefab = fireBullet;
        bulletPrefab2 = waterBullet;
    }
    void Update()
    {
        bombNumber.text = currentBombs.ToString();
        bombTotalNumber.text = bombLimit.ToString();
        bulletNumber.text = bullets.ToString();
        bulletTotalNumber.text = totalBullets.ToString();
        if (Input.GetKeyDown(KeyCode.Mouse0) && bullets > 0)
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1) && Time.time > timeLastBullet + delayBetweenShots && currentBombs > 0)
        {
            ShootSpecial();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            fire = true;
            //reload.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            fire = false;
            //reload.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            MoreBombs();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            MoreBullets();
        }

        if (fire == true)
        {
            weaponChanger.SetActive(true);
        }
        if (fire == false)
        {
            weaponChanger.SetActive(false);
        }

        if (bullets <= 0)
        {
            rechargeAnim.SetBool("recharging", true);
            rechargeSprite.enabled = true;
        }
    }

    void Shoot()
    {
        bullets--;
        if (fire)
        {
            //shoot.Play();
            timeLastShot = Time.time;
            for(int i = 0; i < currentBullets; i++)
            {
                GameObject bullet2 = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
                Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>();
                float horizontalForce = Mathf.Cos(initialAngle * (i-2));
                float verticalForce = Mathf.Sin(initialAngle * (i - 2));
                if (bulletPrefab == windBullet)
                {
                    rb2.AddForce(firepoint.right * bulletforce * horizontalForce* 999, ForceMode2D.Impulse);
                    rb2.AddForce(firepoint.up * bulletforce * verticalForce * 999, ForceMode2D.Impulse);
                }
                else
                {
                    rb2.AddForce(firepoint.right * bulletforce * horizontalForce, ForceMode2D.Impulse);
                    rb2.AddForce(firepoint.up * bulletforce * verticalForce, ForceMode2D.Impulse);
                }
                
            }
            
        }
        else
        {
            //shoot.Play();
            timeLastShot = Time.time;
            for (int i = 0; i < currentBullets; i++)
            {
                GameObject bullet = Instantiate(bulletPrefab2, firepoint.position, firepoint.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                float horizontalForce = Mathf.Cos(initialAngle * (i - 2));
                float verticalForce = Mathf.Sin(initialAngle * (i - 2));
                if (bulletPrefab2 == windBullet)
                {
                    rb.AddForce(firepoint.right * bulletforce * horizontalForce * 999, ForceMode2D.Impulse);
                    rb.AddForce(firepoint.up * bulletforce * verticalForce * 999, ForceMode2D.Impulse);
                }
                else
                {
                    rb.AddForce(firepoint.right * bulletforce * horizontalForce, ForceMode2D.Impulse);
                    rb.AddForce(firepoint.up * bulletforce * verticalForce, ForceMode2D.Impulse);
                }
            }
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

    public void Recharge()
    {
        bullets = totalBullets;
        rechargeAnim.SetBool("recharging", false);
        rechargeSprite.enabled = false;
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

    public void MoreTotalBullets()
    {
        totalBullets = totalBullets + 20;
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

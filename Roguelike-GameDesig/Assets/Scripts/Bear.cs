using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Pathfinding;

public class Bear : MonoBehaviour
{
    public float hp = 6;
    public int maxHp = 10;
    public int damage;
    public Transform hpBar;
    public UnityEvent activate;
    public UnityEvent dead;
    //public AudioSource roar;
    public GameObject rechargePrefab;
    public Animator anim;
    public AIPath aipath;
    public SpriteRenderer spriteRenderer;
    int random;
    public GameObject TheEnemy;
    public Transform TheEnemyTransform;
    public Transform playerTransform;
    public AIPath playerPath;
    EnemySpawner enemySpawner;
    EnemySpawner enemySpawner2;
    EnemySpawner enemySpawner3;
    EnemySpawner enemySpawner4;
    EnemySpawner enemySpawner5;
    EnemySpawner enemySpawner6;
    EnemySpawner enemySpawner7;
    EnemySpawner enemySpawner8;
    EnemySpawner enemySpawner9;
    public GameObject Spawner;
    public GameObject Spawner2;
    public GameObject Spawner3;
    public GameObject Spawner4;
    public GameObject Spawner5;
    public GameObject Spawner6;
    public GameObject Spawner7;
    public GameObject Spawner8;
    public GameObject Spawner9;
    public bool shooter = false;

    public GameObject fire;
    public GameObject electricity;
    public Transform spriteGoblin;

    bool burning = false;
    float lastBurned = 0;
    float delayBurns = 0.2f;
    int knockbackForce = 200;

    private void Start()
    {
        random = Random.Range(0,10);
        hpBar.localScale = new Vector2(maxHp/5, 1);
        enemySpawner = Spawner.GetComponent<EnemySpawner>();
        enemySpawner2 = Spawner2.GetComponent<EnemySpawner>();
        enemySpawner3 = Spawner3.GetComponent<EnemySpawner>();
        enemySpawner4 = Spawner4.GetComponent<EnemySpawner>();
        enemySpawner5 = Spawner5.GetComponent<EnemySpawner>();
        enemySpawner6 = Spawner6.GetComponent<EnemySpawner>();
        enemySpawner7 = Spawner7.GetComponent<EnemySpawner>();
        enemySpawner8 = Spawner8.GetComponent<EnemySpawner>();
        enemySpawner9 = Spawner9.GetComponent<EnemySpawner>();
        damage = 1;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("I am Getting hit");
        if (!collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.CompareTag("DoubleDamage"))
            {
                hp = hp - 4;
                hpBar.localScale = new Vector2(hpBar.localScale.x - 1/5f * 4f, 1);
            }
            else if (collision.gameObject.CompareTag("Bomb"))
            {
                hp = hp - 0;
            }
            else
            {
                hp--;
                hpBar.localScale = new Vector2(hpBar.localScale.x - 1 / 5f, 1);
                print(hp);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //activate.Invoke();
        //anim.SetBool("Active", true);
        /*if (other.CompareTag("Player"))
        {
            float angle = Mathf.Atan2( playerTransform.position.y - transform.position.y, playerTransform.position.x - transform.position.x) * Mathf.Rad2Deg;
            print(angle);
            GameObject bulletShot = Instantiate(enemyBullet,transform.position, Quaternion.Euler(0,0,angle));
            Rigidbody2D rb = bulletShot.GetComponent<Rigidbody2D>();
            float xcomponent = Mathf.Cos(angle * Mathf.PI / 180) * 10;
            float ycomponent = Mathf.Sin(angle * Mathf.PI / 180) * 10;
            Vector3 forceapplied = new Vector3(xcomponent, ycomponent, 0);
            print(forceapplied);
            rb.AddForce(forceapplied, ForceMode2D.Impulse);
        }*/

    }

    private void Update()
    {
        float angle = Mathf.Atan2(playerTransform.position.y - transform.position.y, playerTransform.position.x - transform.position.x) * Mathf.Rad2Deg;
        spriteGoblin.rotation = Quaternion.Euler(0, 0, angle + 180);
        TheEnemyTransform = gameObject.transform;
        if (hp <= 0)
        {
            //dead.Invoke();
            enemySpawner.DefeatedEnemy();
            enemySpawner2.DefeatedEnemy();
            enemySpawner3.DefeatedEnemy();
            enemySpawner4.DefeatedEnemy();
            enemySpawner5.DefeatedEnemy();
            enemySpawner6.DefeatedEnemy();
            enemySpawner7.DefeatedEnemy();
            enemySpawner8.DefeatedEnemy();
            enemySpawner9.DefeatedEnemy();
            if (random <= 1)
            {
                Instantiate(rechargePrefab, transform.position, Quaternion.identity);
            }
            if (shooter)
            {
                enemySpawner3.SpawnShooter();
            }
            Destroy(TheEnemy);
            
        }

        if (aipath.desiredVelocity.x >= 0.01f)
        {
            spriteRenderer.flipX = false;
        }
        else if (aipath.desiredVelocity.x <= -0.01f)
        {
            spriteRenderer.flipX = true;
        }
        
        if (burning)
        {
            for (int i = 0; i <= 4; i++)
            {
                if (Time.time > lastBurned + delayBurns)
                {
                    hp--;
                    hpBar.localScale = new Vector2(hpBar.localScale.x - 1 / 5f, 1);
                    print("current hp: " + hp);
                    lastBurned = Time.time;
                }

                if (i >= 4)
                {
                    burning = false;
                    fire.SetActive(false);
                }
            }
        }

    }

    public void ExtraDamage()
    {
        hp = hp/2;
        print("Amount of Damage: " + hp);
    }

    public void ApplyFire()
    {
        fire.SetActive(true);
        lastBurned = Time.time;
        burning = true;
    }

    public void ApplyWind(Transform bulletTransform)
    {
        Vector2 difference = (transform.position - bulletTransform.position).normalized;
        Vector2 force = difference * knockbackForce;
        Rigidbody2D rb = TheEnemy.GetComponent<Rigidbody2D>();
        rb.AddForce(force, ForceMode2D.Impulse);
    }

    public void ApplyElectricity()
    {
        GameObject electricBall = Instantiate(electricity,transform.position + new Vector3 (0,0,12),transform.rotation);
        electricBall.transform.parent = gameObject.transform;
        electricBall.gameObject.layer = LayerMask.NameToLayer("Bullets");
        //Collider2D ballCollision = electricBall.GetComponent<Collider2D>();
        //ballCollision.isTrigger = true;
        
    }

    public void HitByElectric()
    {
        hp--;
        hpBar.localScale = new Vector2(hpBar.localScale.x - 1 / 5f, 1);
        print(hp);
    }
}


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
    public Transform playerTransform;
    public AIPath playerPath;
    EnemySpawner enemySpawner;
    EnemySpawner enemySpawner2;
    public GameObject Spawner;
    public GameObject Spawner2;

    private void Start()
    {
        random = Random.Range(0,10);
        hpBar.localScale = new Vector2(maxHp/5, 1);
        enemySpawner = Spawner.GetComponent<EnemySpawner>();
        enemySpawner2 = Spawner2.GetComponent<EnemySpawner>();
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
                hpBar.localScale = new Vector2(hpBar.localScale.x - 1 / 5f * damage, 1);
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
        if (hp <= 0)
        {
            dead.Invoke();
            enemySpawner.DefeatedEnemy();
            enemySpawner2.DefeatedEnemy();
            if (random <= 1)
            {
                Instantiate(rechargePrefab, transform.position, Quaternion.identity);
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
        
    }

    public void ExtraDamage()
    {
        hp = hp/2;
        print("Amount of Damage: " + hp);
    }
}


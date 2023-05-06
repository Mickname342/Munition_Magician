using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class ApplyWater : MonoBehaviour
{
    AIPath script;
    Bear bear;
    GameObject enemy;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //enemy = collision.transform.parent.gameObject;
            script = collision.gameObject.GetComponent<AIPath>();
            enemy = collision.transform.GetChild(0).gameObject;
            bear = enemy.GetComponent<Bear>();
            script.maxSpeed = 4;
            bear.ApplyWater();
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyFire : MonoBehaviour
{
    Bear script;
    GameObject enemy;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemy = collision.transform.GetChild(0).gameObject;
            script = enemy.GetComponent<Bear>();
            script.ApplyFire();
        }

    }
}

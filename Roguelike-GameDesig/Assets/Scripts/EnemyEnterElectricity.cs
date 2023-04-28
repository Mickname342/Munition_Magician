using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEnterElectricity : MonoBehaviour
{
    GameObject enemy;
    Bear script;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            enemy = collision.gameObject;
            script = collision.GetComponent<Bear>();
            script.HitByElectric();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChircleThings : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject enemy;
    Bear bear;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("I detected something");
        if (collision.CompareTag("Enemy"))
        {
            bear = collision.GetComponent<Bear>();
            bear.HpDown();
        }
    }
}

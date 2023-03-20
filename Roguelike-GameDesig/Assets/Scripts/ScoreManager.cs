using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public Text hpText;
    // Start is called before the first frame update

    int totalHp = 5;
    void Start()
    {
        hpText.text = totalHp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        hpText.text = totalHp.ToString();
    }

    public void Damaged()
    {
        print("damaged");
        totalHp--;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public Text hpText;
    public GameObject upgradeSelect;
    public Text upgrade1Text;
    public Text upgrade2Text;
    public ScriptableUpgrade upgrade1;
    public ScriptableUpgrade upgrade2;
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

    public void RoundEnded()
    {
        upgrade1Text.text = upgrade1.upgradeName;
        upgrade2Text.text = upgrade2.upgradeName;
        upgradeSelect.SetActive(true);
    }
}

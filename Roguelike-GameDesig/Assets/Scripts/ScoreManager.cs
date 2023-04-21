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
    public RectTransform posUpgrade1;
    public RectTransform posUpgrade2;
    public RectTransform upgrade1pos;
    public RectTransform upgrade2pos;
    public RectTransform upgrade3pos;
    // Start is called before the first frame update

    int upgradeRandomiser1;
    int upgradeRandomiser2;

    public int numberOfUpgrades = 3;

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
        upgradeRandomiser1 = Random.Range(0, numberOfUpgrades);
        upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
        while (upgradeRandomiser2 == upgradeRandomiser1)
        {
            upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
        }
        switch (upgradeRandomiser1)
        {
            case 0:
                upgrade1pos.position = posUpgrade1.position;
                break;
            case 1:
                upgrade2pos.position = posUpgrade1.position;
                break;
            case 2:
                upgrade3pos.position = posUpgrade1.position;
                break;
        }
        switch (upgradeRandomiser2)
        {
            case 0:
                upgrade1pos.position = posUpgrade2.position;
                break;
            case 1:
                upgrade2pos.position = posUpgrade2.position;
                break;
            case 2:
                upgrade3pos.position= posUpgrade2.position;
                break;
        }
        upgrade1Text.text = upgrade1.upgradeName;
        upgrade2Text.text = upgrade2.upgradeName;
        upgradeSelect.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public Text hpText;
    public GameObject upgradeSelect;
    public GameObject OKButton;
    public Text upgrade1Text;
    public Text upgrade2Text;
    public ScriptableUpgrade upgrade1;
    public ScriptableUpgrade upgrade2;
    public RectTransform defaultPos;
    public RectTransform posUpgrade1;
    public RectTransform posUpgrade2;
    public RectTransform upgrade1pos;
    public RectTransform upgrade2pos;
    public RectTransform upgrade3pos;
    public RectTransform upgrade4pos;
    public RectTransform upgrade5pos;
    public RectTransform upgrade6pos;
    public RectTransform upgrade7pos;
    // Start is called before the first frame update

    int upgradeRandomiser1;
    int upgradeRandomiser2;
    int previousUpgrade1 = -1;
    int previousUpgrade2 = -1;

    public int numberOfUpgrades = 7;

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

    public void HpRecover()
    {
        totalHp = 5;
    }

    public void RoundEnded()
    {
        upgradeRandomiser1 = Random.Range(0, numberOfUpgrades);
        upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
        if (upgradeRandomiser1 == previousUpgrade1)
        {
            upgradeRandomiser1 = Random.Range(0, numberOfUpgrades);
        }
        if (upgradeRandomiser2 == previousUpgrade2)
        {
            upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
        }
        while (upgradeRandomiser2 == upgradeRandomiser1)
        {
            upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
        }
        print("upgrade 1 nº: " + upgradeRandomiser1);
        print("upgrade 2 nº: " + upgradeRandomiser2);
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
            case 3:
                upgrade4pos.position = posUpgrade1.position;
                break;
            case 4:
                upgrade5pos.position = posUpgrade1.position;
                break;
            case 5:
                upgrade6pos.position = posUpgrade1.position;
                break;
            case 6:
                upgrade7pos.position = posUpgrade1.position;
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
                upgrade3pos.position = posUpgrade2.position;
                break;
            case 3:
                upgrade4pos.position = posUpgrade2.position;
                break;
            case 4:
                upgrade5pos.position = posUpgrade2.position;
                break;
            case 5:
                upgrade6pos.position = posUpgrade2.position;
                break;
            case 6:
                upgrade7pos.position = posUpgrade2.position;
                break;
        }
        //upgrade1Text.text = upgrade1.upgradeName;
        //upgrade2Text.text = upgrade2.upgradeName;
        previousUpgrade1 = upgradeRandomiser1;
        previousUpgrade2 = upgradeRandomiser2;
        upgradeSelect.SetActive(true);
    }

    public void ReturnOffscreen()
    {
        upgrade1pos.position = defaultPos.position;
        upgrade2pos.position = defaultPos.position;
        upgrade3pos.position = defaultPos.position;
        upgrade4pos.position = defaultPos.position;
        upgrade5pos.position = defaultPos.position;
        upgrade6pos.position = defaultPos.position;
        upgrade7pos.position = defaultPos.position;
    }
}

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
    public RectTransform posUpgrade3;
    public RectTransform upgrade1pos;
    public RectTransform upgrade2pos;
    public RectTransform upgrade3pos;
    public RectTransform upgrade4pos;
    public RectTransform upgrade5pos;
    public RectTransform upgrade6pos;
    public RectTransform upgrade7pos;
    public RectTransform upgrade8pos;
    public RectTransform upgrade9pos;
    public RectTransform upgrade10pos;
    public RectTransform upgrade11pos;
    public RectTransform upgrade12pos;
    public RectTransform upgrade13pos;
    public RectTransform upgrade14pos;

    bool fire = false;
    bool water = false;
    bool wind = false;
    bool electricity = false;
    bool balls = false;
    bool cross = false;
    bool contact = false;
    bool electricPlayer = false;
    bool bigBullet = false;
    // Start is called before the first frame update

    int upgradeRandomiser1;
    int upgradeRandomiser2;
    int upgradeRandomiser3;
    int previousUpgrade1 = -1;
    int previousUpgrade2 = -1;
    int previousUpgrade3 = -1;

    public int numberOfUpgrades = 14;

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

    public void RegainHP()
    {
        totalHp++;
    }

    public void RoundEnded()
    {
        upgradeRandomiser1 = Random.Range(0, numberOfUpgrades);
        upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
        upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
        if (upgradeRandomiser1 == previousUpgrade1)
        {
            upgradeRandomiser1 = Random.Range(0, numberOfUpgrades);
        }
        if (upgradeRandomiser2 == previousUpgrade2)
        {
            upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
        }
        if (upgradeRandomiser3 == previousUpgrade3)
        {
            upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
        }
        if (fire == true)
        {
            while (upgradeRandomiser1 == 7)
            {
                upgradeRandomiser1 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser2 == 7)
            {
                upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser3 == 7)
            {
                upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
            }
        }
        if (water == true)
        {
            while (upgradeRandomiser1 == 8)
            {
                upgradeRandomiser1 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser2 == 8)
            {
                upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser3 == 8)
            {
                upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
            }
        }
        if (wind == true)
        {
            while (upgradeRandomiser1 == 9)
            {
                upgradeRandomiser1 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser2 == 9)
            {
                upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser3 == 9)
            {
                upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
            }
        }
        if (electricity == true)
        {
            while (upgradeRandomiser1 == 10)
            {
                upgradeRandomiser1 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser2 == 10)
            {
                upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser3 == 10)
            {
                upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
            }
        }
        if (balls == true)
        {
            while (upgradeRandomiser1 == 11)
            {
                upgradeRandomiser1 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser2 == 11)
            {
                upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser3 == 11)
            {
                upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
            }
        }
        if (cross == true)
        {
            while (upgradeRandomiser1 == 12)
            {
                upgradeRandomiser1 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser2 == 12)
            {
                upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser3 == 12)
            {
                upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
            }
        }
        if (bigBullet == true)
        {
            while (upgradeRandomiser1 == 13)
            {
                upgradeRandomiser1 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser2 == 13)
            {
                upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser3 == 13)
            {
                upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
            }
        }
        if (contact == true)
        {
            while (upgradeRandomiser1 == 5)
            {
                upgradeRandomiser1 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser2 == 5)
            {
                upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser3 == 5)
            {
                upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
            }
        }
        if (electricPlayer == true)
        {
            while (upgradeRandomiser1 == 6)
            {
                upgradeRandomiser1 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser2 == 6)
            {
                upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
            }
            while (upgradeRandomiser3 == 6)
            {
                upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
            }
        }
        while (upgradeRandomiser2 == upgradeRandomiser1)
        {
            upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
            if (fire == true)
            {
                while (upgradeRandomiser2 == 7)
                {
                    upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
                }
            }
            if (water == true)
            {
                while (upgradeRandomiser2 == 8)
                {
                    upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
                }
            }
            if (wind == true)
            {
                while (upgradeRandomiser2 == 9)
                {
                    upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
                }
            }
            if (electricity == true)
            {
                while (upgradeRandomiser2 == 10)
                {
                    upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
                }
            }
            if (balls == true)
            {
                while (upgradeRandomiser2 == 11)
                {
                    upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
                }
            }
            if (cross == true)
            {
                while (upgradeRandomiser2 == 12)
                {
                    upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
                }
            }
            if (bigBullet == true)
            {
                while (upgradeRandomiser2 == 13)
                {
                    upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
                }
            }
            if (contact == true)
            {
                while (upgradeRandomiser2 == 5)
                {
                    upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
                }
            }
            if (electricPlayer == true)
            {
                while (upgradeRandomiser2 == 6)
                {
                    upgradeRandomiser2 = Random.Range(0, numberOfUpgrades);
                }
            }
        }
        while (upgradeRandomiser3 == upgradeRandomiser1 || upgradeRandomiser3 == upgradeRandomiser2)
        {
            upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
            if (fire == true)
            {
                while (upgradeRandomiser3 == 7)
                {
                    upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
                }
            }
            if (water == true)
            {
                while (upgradeRandomiser3 == 8)
                {
                    upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
                }
            }
            if (wind == true)
            {
                while (upgradeRandomiser3 == 9)
                {
                    upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
                }
            }
            if (electricity == true)
            {
                while (upgradeRandomiser3 == 10)
                {
                    upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
                }
            }
            if (balls == true)
            {
                while (upgradeRandomiser3 == 11)
                {
                    upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
                }
            }
            if (cross == true)
            {
                while (upgradeRandomiser3 == 12)
                {
                    upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
                }
            }
            if (bigBullet == true)
            {
                while (upgradeRandomiser3 == 13)
                {
                    upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
                }
            }
            if (contact == true)
            {
                while (upgradeRandomiser3 == 5)
                {
                    upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
                }
            }
            if (electricPlayer == true)
            {
                while (upgradeRandomiser3 == 6)
                {
                    upgradeRandomiser3 = Random.Range(0, numberOfUpgrades);
                }
            }
        }
        //print("upgrade 1 nº: " + upgradeRandomiser1);
        //print("upgrade 2 nº: " + upgradeRandomiser2);
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
            case 7:
                upgrade8pos.position = posUpgrade1.position;
                break;
            case 8:
                upgrade9pos.position = posUpgrade1.position;
                break;
            case 9:
                upgrade10pos.position = posUpgrade1.position;
                break;
            case 10:
                upgrade11pos.position = posUpgrade1.position;
                break;
            case 11:
                upgrade12pos.position = posUpgrade1.position;
                break;
            case 12:
                upgrade13pos.position = posUpgrade1.position;
                break;
            case 13:
                upgrade14pos.position = posUpgrade1.position;
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
            case 7:
                upgrade8pos.position = posUpgrade2.position;
                break;
            case 8:
                upgrade9pos.position = posUpgrade2.position;
                break;
            case 9:
                upgrade10pos.position = posUpgrade2.position;
                break;
            case 10:
                upgrade11pos.position = posUpgrade2.position;
                break;
            case 11:
                upgrade12pos.position = posUpgrade2.position;
                break;
            case 12:
                upgrade13pos.position = posUpgrade2.position;
                break;
            case 13:
                upgrade14pos.position = posUpgrade2.position;
                break;
        }
        switch (upgradeRandomiser3)
        {
            case 0:
                upgrade1pos.position = posUpgrade3.position;
                break;
            case 1:
                upgrade2pos.position = posUpgrade3.position;
                break;
            case 2:
                upgrade3pos.position = posUpgrade3.position;
                break;
            case 3:
                upgrade4pos.position = posUpgrade3.position;
                break;
            case 4:
                upgrade5pos.position = posUpgrade3.position;
                break;
            case 5:
                upgrade6pos.position = posUpgrade3.position;
                break;
            case 6:
                upgrade7pos.position = posUpgrade3.position;
                break;
            case 7:
                upgrade8pos.position = posUpgrade3.position;
                break;
            case 8:
                upgrade9pos.position = posUpgrade3.position;
                break;
            case 9:
                upgrade10pos.position = posUpgrade3.position;
                break;
            case 10:
                upgrade11pos.position = posUpgrade3.position;
                break;
            case 11:
                upgrade12pos.position = posUpgrade3.position;
                break;
            case 12:
                upgrade13pos.position = posUpgrade3.position;
                break;
            case 13:
                upgrade14pos.position = posUpgrade3.position;
                break;
        }
        //upgrade1Text.text = upgrade1.upgradeName;
        //upgrade2Text.text = upgrade2.upgradeName;
        previousUpgrade1 = upgradeRandomiser1;
        previousUpgrade2 = upgradeRandomiser2;
        previousUpgrade3 = upgradeRandomiser3;
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
        upgrade8pos.position = defaultPos.position;
        upgrade9pos.position = defaultPos.position;
        upgrade10pos.position = defaultPos.position;
        upgrade11pos.position = defaultPos.position;
        upgrade12pos.position = defaultPos.position;
        upgrade13pos.position = defaultPos.position;
        upgrade14pos.position = defaultPos.position;

    }

    public void AddFire()
    {
        fire = true;
    }
    public void AddWater()
    {
        water = true;
    }
    public void AddWind()
    {
        wind = true;
        //print("I added wind");
    }
    public void AddelEctricity()
    {
        electricity = true;
    }

    public void AddBalls() 
    { 
        balls = true;
    }

    public void AddCross()
    {
        cross = true;
    }

    public void AddContact()
    {
        contact = true;
    }

    public void PlayerElectricity()
    {
        electricPlayer = true;
    }

    public void AddBigBullet()
    {
        bigBullet = true;
    }

}


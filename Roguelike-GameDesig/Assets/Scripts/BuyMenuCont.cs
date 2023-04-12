using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyMenuCont : MonoBehaviour
{
    public GameObject[] opts;
    public bool[] chosen;
    public float roundCount;
    // Start is called before the first frame update
    void Start()
    {
        chosen[chosen.Length - 1] = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            roundCount++;
            menuUp();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            //Time.timeScale = 1;
            /*for (int i = 0; i < opts.Length; i++)
            {
                opts[i].SetActive(false);
            }*/
        }
    }

    void menuUp()
    {
        if(roundCount == 3 || roundCount == 6 || roundCount == 9)
        {
            //Time.timeScale = 0;
            if (chosen[0] == false)
            {
                opts[0].SetActive(true);
            }           
            if (chosen[1] == false)
            {
                opts[1].SetActive(true);
            }          
            if (chosen[2] == false)
            {
                opts[2].SetActive(true);
            }        
            if (chosen[3] == false)
            {
                opts[3].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < opts.Length; i++)
            {
                opts[i].SetActive(false);
            }
        }
    }

    public void Choose1()
    {
        chosen[0] = true;
        opts[0].SetActive(false);
        for (int i = 0; i < opts.Length; i++)
        {
            opts[i].SetActive(false);
        }
        Time.timeScale = 1;
    } 
    public void Choose2()
    {
        chosen[1] = true;
        opts[1].SetActive(false);
        for (int i = 0; i < opts.Length; i++)
        {
            opts[i].SetActive(false);
        }
        Time.timeScale = 1;
    }
    public void Choose3()
    {
        chosen[2] = true;
        opts[2].SetActive(false);
        for (int i = 0; i < opts.Length; i++)
        {
            opts[i].SetActive(false);
        }
        Time.timeScale = 1;
    }
    public void Choose4()
    {
        chosen[3] = true;
        opts[3].SetActive(false);
        for (int i = 0; i < opts.Length; i++)
        {
            opts[i].SetActive(false);
        }
        Time.timeScale = 1;
    }
}

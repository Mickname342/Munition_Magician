using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Reload the current scene when R & - are pressed
        /*if (Input.GetKey(KeyCode.R) && Input.GetKeyDown(KeyCode.Minus))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
        // Quit the application when Escape is pressed
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
            print("I will exit on unity builds");
        }*/
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void stopTime()
    {
        Time.timeScale = 0f;
    }
}

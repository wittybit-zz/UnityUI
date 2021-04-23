using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMgmt : MonoBehaviour
{
    [SerializeField] GameObject exitPanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex != 0)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                if (exitPanel)
                {
                    exitPanel.SetActive(true);
                    //if (Input.GetKeyDown(KeyCode.Escape))
                    //{
                    //    Debug.Log("exit on keypress");
                    //    Application.Quit();
                    //}
                }
            }
        }

        
    }
    public void btnChangeScene(string sceneName)
    {
        Debug.Log("Changed Scene to " + sceneName);
        SceneManager.LoadScene(sceneName);
    }

    public void RestartGame()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        Debug.Log("Scene " + sceneName + " Loaded");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }

    public void displayExitPanel()
    {

        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            Debug.Log("Scene switched to 0");
            SceneManager.LoadScene(0);
        }
        else
        {
            if (exitPanel)
            {
                Debug.Log("Panel Displayed");
                exitPanel.SetActive(true);
            }
        }
    }

    public void onUserClickYesNo(int choice) // choice == 1 yes     choice == 0 no
    {
        if (choice == 1)
        {
            Debug.Log("Application quit");
            Application.Quit();
        } else if(choice == 0)
        {
            Debug.Log("Exit cancelled");
            exitPanel.SetActive(false);
        }
        exitPanel.SetActive(false);
    }
}

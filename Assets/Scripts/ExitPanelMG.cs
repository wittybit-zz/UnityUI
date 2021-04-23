using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitPanelMG : MonoBehaviour
{
    [SerializeField] GameObject exitPanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex != 0)
            {
                SceneManager.LoadScene(0);
            } else
            {
                if (exitPanel)
                {
                    exitPanel.SetActive(true);
                }
            }
        }
    }

    public void onUserClickYesNo(int choice) // choice == 1 yes     choice == 0 no
    {
        if(choice == 1)
        {
            Debug.Log("Application quit");
            Application.Quit();
        }
        exitPanel.SetActive(false);
    }
}
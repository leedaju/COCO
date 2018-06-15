using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public GameObject PausePanel;

    

    public GameObject StartTrigger;

    void Start()
    {
        PausePanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GobacktoGame()
    {
        PausePanel.SetActive(false);
        
        
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }


    void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            PausePanel.SetActive(true);
            
            StartTrigger.SetActive(false);
        }
	}
}

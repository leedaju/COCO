using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Success : MonoBehaviour {

	public void RetryGame()
    {
        SceneManager.LoadScene("CardGame");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

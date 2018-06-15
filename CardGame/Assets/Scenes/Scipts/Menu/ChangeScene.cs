using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void ChangeToCardGame()
    {
        SceneManager.LoadScene("CardGame");
    }

    public void ChangeToQuizGame()
    {
        SceneManager.LoadScene("QuizGame");
    }

    public void ChangeToCatGame()
    {
        SceneManager.LoadScene("catgame");
    }
}

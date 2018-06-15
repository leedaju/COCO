using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public class GameManager : MonoBehaviour {

    public Questions[] questions;
    private static List<Questions> unanswerQuestions;

    private Questions currentQuestions;

    public Text Answer1_Star;
    public Text Answer2_Star;
    public Text Answer3_Star;

    public InputField answer1;
    public InputField answer2;
    public InputField answer3;

    public GameObject StarPanel;
    public GameObject NextBtnPanel;

    [SerializeField]
    private Text questionText1;
    [SerializeField]
    private Text questionText2;
    [SerializeField]
    private Text questionText3;
    [SerializeField]
    private Text questionText4;
    [SerializeField]
    private Text questionText5;
    [SerializeField]
    private Text questionText6;
    [SerializeField]
    private Text questionText7;
    [SerializeField]
    private Text questionText8;
    [SerializeField]
    private Text questionText9;
    [SerializeField]
    private Text questionText10;
    [SerializeField]
    private Text questionText11;
    [SerializeField]
    private Text questionText12;
    [SerializeField]
    private Text questionText13;
    [SerializeField]
    private Text questionText14;
    [SerializeField]
    private Text questionText15;


    [SerializeField]
    private Text ResultText1;
    [SerializeField]
    private Text ResultText2;
    [SerializeField]
    private Text ResultText3;
    [SerializeField]
    private Text ResultText4;
    [SerializeField]
    private Text ResultText5;
    [SerializeField]
    private Text ResultText6;
    [SerializeField]
    private Text ResultText7;
    [SerializeField]
    private Text ResultText8;
    [SerializeField]
    private Text ResultText9;

    public Text Answer1;
    public Text Answer2;
    public Text Answer3;

    void Start()
    {
        if(unanswerQuestions == null || unanswerQuestions.Count == 0)
        {
            unanswerQuestions = questions.ToList<Questions>();
        }

        SetRandomQuestion();

        StarPanel.SetActive(true);
        NextBtnPanel.SetActive(false);

        Answer1_Star.color = Color.black;
        Answer2_Star.color = Color.black;
        Answer3_Star.color = Color.black;

        Answer1_Star.text = "☆";
        Answer2_Star.text = "☆";
        Answer3_Star.text = "☆";

        
    }

    public void SetRandomQuestion()
    {
        answer1.text = "";
        answer2.text = "";
        answer3.text = "";
        int randomQuestionIndex = Random.Range(0, unanswerQuestions.Count);
        currentQuestions = unanswerQuestions[randomQuestionIndex];

        Answer1_Star.color = Color.black;
        Answer2_Star.color = Color.black;
        Answer3_Star.color = Color.black;

        Answer1_Star.text = "☆";
        Answer2_Star.text = "☆";
        Answer3_Star.text = "☆";
        StarPanel.SetActive(true);
        NextBtnPanel.SetActive(false);
        Answer1.text = "";
        Answer2.text = "";
        Answer3.text = "";

        unanswerQuestions.RemoveAt(randomQuestionIndex);

        questionText1.text = currentQuestions.fact1;
        questionText2.text = currentQuestions.fact2;
        questionText3.text = currentQuestions.fact3;
        questionText4.text = currentQuestions.fact4;
        questionText5.text = currentQuestions.fact5;
        questionText6.text = currentQuestions.fact6;
        questionText7.text = currentQuestions.fact7;
        questionText8.text = currentQuestions.fact8;
        questionText9.text = currentQuestions.fact9;
        questionText10.text = currentQuestions.fact10;
        questionText11.text = currentQuestions.fact11;
        questionText12.text = currentQuestions.fact12;
        questionText13.text = currentQuestions.fact13;
        questionText14.text = currentQuestions.fact14;
        questionText15.text = currentQuestions.fact15;

        ResultText1.text = currentQuestions.result1;
        ResultText2.text = currentQuestions.result2;
        ResultText3.text = currentQuestions.result3;
        ResultText4.text = currentQuestions.result4;
        ResultText5.text = currentQuestions.result5;
        ResultText6.text = currentQuestions.result6;
        ResultText7.text = currentQuestions.result7;
        ResultText8.text = currentQuestions.result8;
        ResultText9.text = currentQuestions.result9;



    }

    public void GoNextProblem()
    {
        Answer1_Star.color = Color.black;
        Answer2_Star.color = Color.black;
        Answer3_Star.color = Color.black;

        Answer1_Star.text = "☆";
        Answer2_Star.text = "☆";
        Answer3_Star.text = "☆";

        SetRandomQuestion();
    }

    public void CheckAnswers()
    {
        if(Answer1.text == currentQuestions.answer1)
        {
            Answer1_Star.color = Color.blue;
            Answer1_Star.text = "★";
        }
        else if(Answer1.text != currentQuestions.answer1)
        {
            Answer1_Star.color = Color.red;
            Answer1_Star.text = "★";
        }
        else if(Answer1.text == "")
        {
            
        }

        if (Answer2.text == currentQuestions.answer2)
        {
            Answer2_Star.color = Color.blue;
            Answer2_Star.text = "★";
        }
        else if (Answer2.text != currentQuestions.answer2)
        {
            Answer2_Star.color = Color.red;
            Answer2_Star.text = "★";
        }
        else if (Answer2.text == "")
        {
            
        }

        if (Answer3.text == currentQuestions.answer3)
        {
            Answer3_Star.color = Color.blue;
            Answer3_Star.text = "★";
        }
        else if (Answer3.text != currentQuestions.answer3)
        {
            Answer3_Star.color = Color.red;
            Answer3_Star.text = "★";
        }
        else if (Answer3.text == "")
        {
            
        }

        if(Answer1.text == currentQuestions.answer1 && Answer2.text == currentQuestions.answer2 && Answer3.text == currentQuestions.answer3)
        {
            StarPanel.SetActive(false);
            NextBtnPanel.SetActive(true);

        }

       


    }


}

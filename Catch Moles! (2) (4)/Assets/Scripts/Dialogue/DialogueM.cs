using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueM : MonoBehaviour
{

    private Queue<string> sentences;


    public Text dialogueText;
    public GameObject Trigger_Start;

    public GameObject DialoguePanel;

    public GameObject StartGameBtn;

    public GameObject exText;






    private void Start()
    {
        sentences = new Queue<string>();

        exText.SetActive(false);



    }

    public void StartDialogue(Dialogue dialogue)
    {


        exText.SetActive(true);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();


    }



    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }



    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    void EndDialogue()
    {
        DialoguePanel.SetActive(false);

        Trigger_Start.SetActive(false);

        StartGameBtn.SetActive(true);

        exText.SetActive(false);
    }

    public void ClickSkip()
    {
        SceneManager.LoadScene("Play");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DisplayNextSentence();
        }
    }
}
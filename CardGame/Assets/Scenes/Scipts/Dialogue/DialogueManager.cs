using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    private Queue<string> sentences;

    
    public Text dialogueText;
    public GameObject Trigger_Start;

    public GameObject DialoguePanel;
    public GameObject explainText;

    bool Skipdialogue;






    private void Start()
    {
        sentences = new Queue<string>();

        Skipdialogue = false;

        explainText.SetActive(false);

    }

    public void StartDialogue(Dialogue dialogue)
    {


        

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

        explainText.SetActive(true);

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
        SceneController.Instance.isReadyTobegin_true();
        Trigger_Start.SetActive(false);
        explainText.SetActive(false);
    }
    void Update()
    {
        if(!Skipdialogue)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                DisplayNextSentence();
            }
        }
        
    }

    public void SkipCLicked()
    {
        Skipdialogue = true;
        SceneController.Instance.isReadyTobegin_true();
        DialoguePanel.SetActive(false);

        Trigger_Start.SetActive(false);
        explainText.SetActive(false);
    }
}

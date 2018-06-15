using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;

    public GameObject TriggerBtn;
    public Button Trigger;

    public GameObject DialogueBox;
    public GameObject NextBtn;

    public Text TriggerBtnText;



    
        


    private void Start()
    {
        NextBtn.SetActive(false);
        TriggerBtn.SetActive(true);
        TriggerBtnText.text = "Start";
    }

    public void TriggerDialogue() 
    {
        
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue); 
        NextBtn.SetActive(true);

        Trigger.interactable = false;

        TriggerBtnText.text = "Tips";


        
    }

    



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogscript : MonoBehaviour
{

    private Button nextButton;
    public TMP_Text dialogueText;
    public GameObject playerObject;
    public GameObject gameMaster;
    private int dialogueIndex = 0;
    public bool startClassMatters;
    public bool Disablebutton;
    
    [TextArea(15, 20)]
    [SerializeField] private string[] dialogueContent;
    public int index = 0;
    [Header("Object trigger (mouseover for tooltip)")]
    [Tooltip("Objects to activate or deactivate at the end of the dialogue. Drag the object you want to activate/deactivate into the array. Leave empty if you don't want to use it.")]
    [SerializeField] private GameObject[] objectTrigger;

    public bool repeatableDialogue;
    [SerializeField] private string repeatDialogue;

    // Start is called before the first frame update
    void Awake()
    {
        if (gameMaster == null)
        {
            gameMaster = GameObject.Find("GameManager");
        }
        
        
        if (Disablebutton == false)
        {
            nextButton = GetComponentInChildren<Button>();
            //dialogueText = GetComponentInChildren<TMP_Text>();
            //dialogueText = this.transform.Find("Content").gameObject.GetComponent<TMP_Text>();
            Debug.Log(dialogueText.name);
            nextButton.onClick.AddListener(DialogueButton);
        }
    }

    // This code is called every time the object is enabled
    void OnEnable()
    {
        

        if (dialogueContent.Length <= 0)
        {
            Debug.Log("ERROR: no dialogue content");
            EndDialogue();
        }
        else
        {
            if (playerObject != null)
            {
                //Code here to disable movement inside the player object. This could be a simple bool that's turned off.
                //Could look something like this:
                //playerObject.GetComponent<playerScript>().inDialogue = true
                //in the above example there is a bool within the playerScript that is called "inDialogue" that is set to true.
            }
            if (repeatableDialogue == true && dialogueContent.Length == dialogueIndex)
            {
                dialogueText.text = repeatDialogue;
            }
            else
            {
                StartDialogue();
            }
        }
    }

    private void StartDialogue()
    {
        NextLine();
    }

    private void NextLine()
    {
        if (startClassMatters == true)
            {
                index = gameMaster.GetComponent<Gamemaster>().startclass;
            }

        Debug.Log("This object is " + transform.name + " and Index is" + index);
        if (index != 0) //Index används bara om man spelar upp ett meddelande.
        {
            if (dialogueText.text == dialogueContent[index - 1])
            {
                EndDialogue();
            }

            if (index > dialogueContent.Length)
            {
                Debug.Log("Error; index to long");
            }
            else
            {
                
                dialogueText.text = dialogueContent[index -1];
            }
        }
        else
        {
            if (dialogueIndex < dialogueContent.Length)
            {
                dialogueText.text = dialogueContent[dialogueIndex];
                dialogueIndex++;
            }
            else
            {
                EndDialogue();
            }
        }
    }

    public void DialogueButton()
    {
        NextLine();
    }

    private void EndDialogue()
    {
        if (repeatableDialogue == false)
        {
            dialogueIndex = 0; //if the dialogue is supposed to be repeatable then the dialogueIndex will return to 0.
        }


        if (objectTrigger.Length > 0)
        {
            foreach (GameObject obj in objectTrigger)
            {
                obj.SetActive(!obj.activeSelf); //Flips the active status of the object. If object active is true, it becomes false and vice versa.
            }
        }
        gameObject.SetActive(false);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterCreator : MonoBehaviour
{
    public GameObject GameManager;
    public TMP_InputField textInput;
    public TMP_InputField textInput2;
    public GameObject NextDialog;

    public Button Button1;
    public Button Button2;
    public Button Button3;

    public bool Name = false;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");

        if(Button1 != null)
        {
            Button1.onClick.AddListener(ButtonOne);
        }
        if (Button2 != null)
        {
            Button2.onClick.AddListener(ButtonTwo);
        }
        if (Button3 != null)
        {
            Button3.onClick.AddListener(ButtonThree);
        }
    }

    public void ButtonOne()
    {
        if (Name == true)
        {
            SetPlayerName();
        }
        else
        {
            ActivateDialoguePanel(1);
        }
        
    }

    public void ButtonTwo()
    {
        ActivateDialoguePanel(2);
    }

    public void ButtonThree()
    {
        ActivateDialoguePanel(3);
    }


    private void SetPlayerName()
    {
        if (textInput != null)
        {
            if (textInput.text == "")
            {

            }

            else
            {
                GameManager.GetComponent<Gamemaster>().playerName = textInput.text;

                GameManager.GetComponent<Gamemaster>().playerName2 = textInput2.text;

                NextDialog.SetActive(true);
                
                gameObject.SetActive(false);
            }
        }
        

    }

    private void ActivateDialoguePanel(int value)
    {
        //Activate a game object
        //Change the variable on the Dialogscript "index" to 0, 1 or 2
        
        if(NextDialog.GetComponent<Dialogscript>() != null)
        {
            NextDialog.GetComponent<Dialogscript>().index = value;
        }
        NextDialog.SetActive(true);
        gameObject.SetActive(false);

    }
}

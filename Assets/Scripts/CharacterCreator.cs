using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterCreator : MonoBehaviour
{
    public GameObject GameManager;
    public TMP_InputField textInput;
    public TMP_InputField textInput2;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
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

                playerName = textInput.text;

                playerName2 = textInput2.text;
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gamemaster : MonoBehaviour
{
    public string playerName = "";
    public TMP_InputField textInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Name is " + playerName);

        if (Input.GetKeyDown(KeyCode.Space))
        {
             SetPlayerName();
        }
    }

    private void SetPlayerName()
    {
        if(textInput != null)
        {
            if(textInput.text == "")
            {

            }

            else
            {
                playerName = textInput.text;
            }
        }
        
    }

}

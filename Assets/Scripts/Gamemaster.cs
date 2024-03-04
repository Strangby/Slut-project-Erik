using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemaster : MonoBehaviour
{
    public string playerName = "";
    public string playerName2 = "";
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Name is " + playerName + playerName2);

        if (Input.GetKeyDown(KeyCode.Space))
        {
             SetPlayerName();
        }
    }

}

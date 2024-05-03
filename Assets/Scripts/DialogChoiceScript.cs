using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogChoiceScript : MonoBehaviour
{

    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;

    // Start is called before the first frame update
    void Start()
    {
        if (Button1 != null)
        {
            Button1.onClick.AddListener(ButtonOne);
        }
        if (Button2 != null)
        {
            Button2.onClick.AddListener(ButtonTwo);
        }
        if (Button3 != null)
        {
            Button3.onClick.AddListener(ButtonFour);
        }
        if (Button4 != null)
        {
            Button4.onClick.AddListener(ButtonFour);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonOne()
    {

    }
    public void ButtonTwo()
    {

    }
    public void ButtonThree()
    {

    }
    public void ButtonFour()
    {

    }
}
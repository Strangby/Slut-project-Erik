using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogChoiceScript : MonoBehaviour
{
    public GameObject Gamemaster;
    public GameObject NextPart;
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public GameObject[] Activate = new GameObject[4];

    // Start is called before the first frame update
    void Start()
    {
        Gamemaster = GameObject.Find("Gamemaster");

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
        ButtonChoice(0);
    }
    public void ButtonTwo()
    {
        ButtonChoice(1);
    }
    public void ButtonThree()
    {
        ButtonChoice(2);
    }
    public void ButtonFour()
    {
        ButtonChoice(3);
    }
    private void ButtonChoice(int exes)
    {
        Activate[exes].SetActive(true);
        NextPart.SetActive(true);
        NextPart.GetComponent<Dialogscript>().index = exes + 1;
        gameObject.SetActive(false);
    }
}
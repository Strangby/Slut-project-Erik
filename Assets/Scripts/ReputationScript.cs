using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReputationScript : MonoBehaviour
{
    public int[] PartySupport = new int[4];
    public GameObject Gamemaster;
    public GameObject parentDialogue;
    private bool SetupComplete = false;

    // Start is called before the first frame update
    void Start()
    {
        Gamemaster = GameObject.Find("GameManager");
        gameObject.SetActive(false);
    }

    void OnEnable()
    {
        if(SetupComplete == false)
        {
            //Villkor med en boolean
            Debug.Log("code running");
            Gamemaster.GetComponent<Gamemaster>().Reputation(PartySupport[0], PartySupport[1], PartySupport[2], PartySupport[3]);
            parentDialogue.SetActive(false);
            bool SetupComplete = true;
            //Boolean blir sann här
        }
    }
}
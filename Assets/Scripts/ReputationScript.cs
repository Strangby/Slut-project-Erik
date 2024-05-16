using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReputationScript : MonoBehaviour
{
    public int[] PartySupport = new int[4];
    public GameObject Gamemaster;

    // Start is called before the first frame update
    void Start()
    {
        Gamemaster = GameObject.Find("Gamemaster");
    }

    void OnEnable()
    {
        Gamemaster.GetComponent<Gamemaster>().Reputation(PartySupport[0], PartySupport[1], PartySupport[2], PartySupport[3]);
    }
}
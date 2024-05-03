using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemaster : MonoBehaviour
{
    public string playerName = "";
    public string playerName2 = "";

    public int startclass;
    public int popularity;
    public int relUPE;
    public int relPSE;
    public int relDPP;
    public int relPEN;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Reputation(int UPE, int PSE, int DPP, int PEN)
    {
        relUPE += UPE;
        relPSE += PSE;
        relDPP += DPP;
        relPEN += PEN;
    }

    public void SetClass(int c_value)
    {
        startclass = c_value;
    }
}

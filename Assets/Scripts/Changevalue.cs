using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changevalue : MonoBehaviour
{
    public GameObject Gamemaster;
    public string varname;
    public int value;

    private void OnEnable()
    {
        changevalue(value, varname);
    }

    void changevalue(int value, string varname)
    {
       // Gamemaster.GetComponent<Gamemaster>().
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyrus : MonoBehaviour
{
    private SpriteRenderer Highlight;
    // Start is called before the first frame update
    void Start()
    {
        Highlight = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        Highlight.set
        Debug.Log("Mouse is over target");
    }

    void OnMouseExit()
    {
        Debug.Log("Mouse is not over target");
    }
}

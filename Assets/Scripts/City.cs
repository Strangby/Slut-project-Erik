using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour
{
    public SpriteRenderer Highlight;
    public GameObject Stad;
    public static bool NoInt;
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
        this.Highlight.enabled = true;

        if (Input.GetMouseButtonDown(0) && NoInt == false)
        {
            Stad.SetActive(true);
            Flipback();
        }
    }

    void OnMouseExit()
    {
        this.Highlight.enabled = false;
    }
    public void Flipback()
    {
        NoInt = !NoInt;
    }
}

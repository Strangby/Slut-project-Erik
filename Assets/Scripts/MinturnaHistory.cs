using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinturnaHistory : MonoBehaviour
{
    public GameObject Panel;
    public Button button;
    public GameObject Minturna;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Panel.SetActive(false);
        Minturna.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

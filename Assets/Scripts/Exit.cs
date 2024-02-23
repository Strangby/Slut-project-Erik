using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public GameObject Panel;
    public Button button;
    public GameObject City;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        City.GetComponent<City>().Flipback();
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer_Controller : MonoBehaviour
{
    TextMeshPro tmp;
    Main_Controller controller;
    // Start is called before the first frame update
    void Start()
    {
        tmp = GetComponent<TextMeshPro>();
        controller = GameObject.Find("PlayController").GetComponent<Main_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.Floor((controller.time) * 100f) / 100f;
        if (time>=0)
        {

            tmp.SetText(time.ToString("00.00"));
        }
        else
        {
            tmp.SetText("BOOM");
        }
    }
}

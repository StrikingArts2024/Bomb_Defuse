using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer_Controller : MonoBehaviour
{
    TextMeshPro tmp;
    Main_Controller controller;

    public GameObject explosion;
    public GameObject resetButton;
    // Start is called before the first frame update
    public bool isRunning;
    public bool isRunningCoroutine;
    
    void timerRunning()
    {
        if (isRunning == false)
        {
            tmp.SetText("CLEAR");
            return;
        }
        float time = Mathf.Floor((controller.time) * 100f) / 100f;
        if (time >= 0)
        {

            tmp.SetText(time.ToString("00.00"));
        }
        else
        {
            tmp.SetText("00.00");
            if(explosion.activeSelf==false) {
                explosion.SetActive(true);
                if (isRunningCoroutine == false)
                {
                    StartCoroutine(resetButtonSetting());
                }
            }
        }
    }
    
    
    IEnumerator resetButtonSetting()
    {

        yield return new WaitForSeconds(4f);

        isRunningCoroutine = true;
        resetButton.SetActive(true);


        yield return null;
    }


    void Start()
    {
        isRunning = true;
        isRunningCoroutine = false;
        tmp = GetComponent<TextMeshPro>();
        controller = GameObject.Find("PlayController").GetComponent<Main_Controller>();
    }



    // Update is called once per frame
    void Update()
    {
        timerRunning();
    }
}

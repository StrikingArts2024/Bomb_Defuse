using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Defuse_Button : MonoBehaviour, click_event
{
    public GameObject[] minigameList;
    public GameObject timer;
    AudioSource audioSource;

    public GameObject resetDisplay;

    public void click()
    {


        bool cheaker = true;

        for (int i = 0; i < minigameList.Length; i++)
        {
            if (cheaker == false)
            {
                continue;
            }
            cheaker = minigameList[i].transform.Find("green").gameObject.activeSelf;
        }
        if (cheaker == true)
        {
            timer.GetComponent<Timer_Controller>().isRunning = false;
            resetDisplay.SetActive(true);
            audioSource.Play();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}

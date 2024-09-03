using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigame_defuse_button : MonoBehaviour,click_event
{
    public GameObject[] minigameList;
    public GameObject timer;
    public void click()
    {


        bool cheaker = true;

        for(int i= 0; i < minigameList.Length; i++)
        {
            cheaker = minigameList[i].transform.Find("green").gameObject.activeSelf;
        }
        if (cheaker == true)
        {
            timer.GetComponent<Timer_Controller>().isRunning = false;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }






}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigame_UpdownControllerLine : MonoBehaviour
{



    public double targetNumber;
    public double nowNumber;
    public GameObject target;
    public GameObject point;
    public bool checking;

    // Start is called before the first frame update
    void Start()
    {
        targetNumber = UnityEngine.Random.Range(-0.05f, 0.05f);
        nowNumber = UnityEngine.Random.Range(-0.05f, 0.05f);
        targetNumber = (Math.Truncate(targetNumber * 100) / 100)*5;
        nowNumber = (Math.Truncate(nowNumber * 100f) / 100)*5;
        target.transform.localPosition = new Vector3(target.transform.localPosition.x, (float)targetNumber, target.transform.localPosition.z);
        point.transform.localPosition = new Vector3(point.transform.localPosition.x, (float)nowNumber, point.transform.localPosition.z);
        CheckAns();
    }

    public void Up()
    {
        if(-0.25<=nowNumber && nowNumber < 0.25)
        {
            nowNumber += 0.05;
            if(nowNumber<-0.25 || nowNumber > 0.25)
            {
                nowNumber = 0.25;
            }
            point.transform.localPosition = new Vector3(point.transform.localPosition.x, (float)nowNumber, point.transform.localPosition.z);
            CheckAns();
        }
        
    }
    public void Down()
    {
        if (-0.25 < nowNumber && nowNumber <= 0.25)
        {
            nowNumber -= 0.05;
            if (nowNumber < -0.25 || nowNumber > 0.25)
            {
                nowNumber = -0.25;
            }
            
            point.transform.localPosition = new Vector3(point.transform.localPosition.x, (float)nowNumber, point.transform.localPosition.z);
            CheckAns();
        }
        

    }
    public void CheckAns()
    {
        Debug.Log("now : " + nowNumber);
        if(Mathf.Abs((float)targetNumber - (float)nowNumber )< 0.001)
        {
           
            checking = true;
        }
        else
        {
            checking = false;
        }
        if (this.transform.parent.parent.gameObject.GetComponent<minigame_UpdownController>() != null)
        {
            this.transform.parent.parent.gameObject.GetComponent<minigame_UpdownController>().clear();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

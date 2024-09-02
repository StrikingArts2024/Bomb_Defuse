using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigame_UpdownControllerLine : MonoBehaviour
{



    public float targetNumber;
    public float nowNumber;
    public GameObject target;
    public GameObject point;
    public bool checking;

    // Start is called before the first frame update
    void Start()
    {
        targetNumber = Random.Range(-0.25f, 0.25f);
        nowNumber = Random.Range(-0.25f, 0.25f);
        targetNumber = Mathf.Floor(targetNumber * 100f) / 100f;
        nowNumber = Mathf.Floor(nowNumber * 100f) / 100f;
        target.transform.localPosition = new Vector3(target.transform.localPosition.x, targetNumber, target.transform.localPosition.z);
        point.transform.localPosition = new Vector3(point.transform.localPosition.x, nowNumber, point.transform.localPosition.z);
        CheckAns();
    }

    public void Up()
    {
        nowNumber += 0.01f;
        point.transform.localPosition = new Vector3(point.transform.localPosition.x, nowNumber, point.transform.localPosition.z);
        CheckAns();
    }
    public void Down()
    {
        nowNumber -= 0.01f;
        point.transform.localPosition = new Vector3(point.transform.localPosition.x, nowNumber, point.transform.localPosition.z);
        CheckAns();

    }
    public void CheckAns()
    {
        if(Mathf.Abs(targetNumber - nowNumber )< 0.001)
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

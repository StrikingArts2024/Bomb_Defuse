using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigame_UpdownControllerButton : MonoBehaviour,click_event
{
    public string control;

    public void click()
    {
        if (control.Equals("up"))
        {
            if(this.transform.parent.gameObject.GetComponent<minigame_UpdownControllerLine>() != null)
            {
                this.transform.parent.gameObject.GetComponent<minigame_UpdownControllerLine>().Up();
            }
        }
        if (control.Equals("down"))
        {
            if (this.transform.parent.gameObject.GetComponent<minigame_UpdownControllerLine>() != null)
            {
                this.transform.parent.gameObject.GetComponent<minigame_UpdownControllerLine>().Down();
            }
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

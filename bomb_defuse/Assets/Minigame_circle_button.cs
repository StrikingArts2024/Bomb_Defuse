using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame_circle_button : MonoBehaviour,click_event
{
    public GameObject pivot;
    public void click()
    {
        Transform parent = this.transform.parent;
        minigame_circle minigame = parent.GetComponent<minigame_circle>();
        float radius = pivot.transform.localEulerAngles.y;
        radius = (radius + 360) % 360;
        if (radius > 0 && radius < 90f)
        {
            if(minigame != null)
            {
                parent.parent.GetComponent<Minigame_circle_controller>().check[minigame.num] = true;
                parent.parent.GetComponent<Minigame_circle_controller>().clear();
                minigame.trig = false;
            }
        }
        else
        {
            if (minigame != null)
            {
                parent.parent.GetComponent<Minigame_circle_controller>().check[minigame.num] = false;
                parent.parent.GetComponent<Minigame_circle_controller>().clear();
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

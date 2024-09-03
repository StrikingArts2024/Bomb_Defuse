using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigame_buttonpuzzle_button : MonoBehaviour,click_event
{


    [SerializeField]
    public Transform[] buttonList;
    public bool[] target;

    // Start is called before the first frame update
    void Start()
    {
        Transform buttonParent = this.transform.parent;
        int index = buttonParent.childCount;
        buttonList = new Transform[index];
        for(int i = 0;i<index;i++)
        {
            buttonList[i] = buttonParent.GetChild(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void click()
    {
        for(int i = 0;i<buttonList.Length;i++)
        {
            if (target[i]) {
                bool act = buttonList[i].gameObject.activeSelf;
                if (act == true)
                {
                    buttonList[i].gameObject.SetActive(false);
                }
                else
                {
                    buttonList[i].gameObject.SetActive(true);

                }
            }
        }
        minigame_buttonpuzzle_controller minigame_controller =  this.transform.parent.parent.GetComponent<minigame_buttonpuzzle_controller>();
        if(minigame_controller != null )
        {
            minigame_controller.clear();
        }
    }
}

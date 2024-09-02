using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigame_UpdownController : MonoBehaviour, clear_event
{


    public GameObject green;
    public GameObject red;
    [SerializeField]
    public GameObject[] valueList;
    public bool[] valueCheckList;
    public void clear()
    {
        for(int i = 0; i < valueList.Length; i++)
        {
            if (valueList[i].GetComponent<minigame_UpdownControllerLine>() != null)
            {
                if (valueList[i].GetComponent<minigame_UpdownControllerLine>().checking == true)
                {
                    valueCheckList[i] = true;
                }
                else
                {
                    valueCheckList[i] = false;
                }
            }
            
        }
        bool check = true;
        for(int i=0;i< valueCheckList.Length; i++) {
            if (valueCheckList[i] == false)
            {
                check = false;
            }
        }
        if (check == true)
        {
            red.SetActive(false);
            green.SetActive(true);
        }
        else
        {
            red.SetActive(true);
            green.SetActive(false);

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

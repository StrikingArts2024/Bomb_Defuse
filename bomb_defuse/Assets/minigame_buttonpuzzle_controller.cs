using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigame_buttonpuzzle_controller : MonoBehaviour,clear_event
{
    public GameObject green;
    public GameObject red;
    public GameObject buttonParent;


    [SerializeField]
    public bool[] check;
    public GameObject[] button;

    // Start is called before the first frame update
    void Start()
    {
        int count = buttonParent.transform.childCount;
        button = new GameObject[count];
        for (int i = 0; i < count; i++)
        {
            button[i] = buttonParent.transform.GetChild(i).gameObject;
        }
        green.SetActive(false);
        red.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clear()
    {
        bool checker = false;
        for (int i = 0; i < button.Length; i++)
        {
            if (button[i].activeSelf == true)
            {
                checker = true;
            }
        }
        if(checker == false)
        {
            green.SetActive(true);
            red.SetActive(false);
        }
        if (checker == true)
        {
            green.SetActive(false);
            red.SetActive(true);
        }




    }
}

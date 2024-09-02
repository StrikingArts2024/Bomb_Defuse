using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame_circle_controller : MonoBehaviour, clear_event
{
    public GameObject green;
    public GameObject red;


    [SerializeField]
    public bool[] check;
    public void clear()
    {
        bool checker = true;
        for(int i = 0; i < check.Length; i++)
        {
            if (check[i] == false)
            {
                checker = false;
            }
        }
        if (checker == false)
        {
            red.SetActive(true);
            green.SetActive(false);
        }
        else
        {
            red.SetActive(false);
            green.SetActive(true);
        }






    }
    // Start is called before the first frame update
    void Start()
    {
        check = new bool[3];
        for(int i = 0; i < check.Length; i++)
        {
            check[i] = false;
        }
        green.SetActive(false);
        red.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mini_gameController : MonoBehaviour,clear_event
{
    public GameObject green;
    public GameObject red;
    public string key;
    public string key_inputfield;

    [SerializeField]
    public GameObject[] buttonList;
    public void clear()
    {
        red.SetActive(false);
        green.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        green.SetActive(false);
        red.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Main_Controller : MonoBehaviour
{
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        time_update();
    }
    void time_update()
    {
        time -= Time.deltaTime;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





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
        hold();
    }
    void time_update()
    {
        time -= Time.deltaTime;
    }



    private float holdTime = 0f;
    // R키를 눌러야 하는 최소 시간 (3초)
    public float requiredHoldTime = 3f;
    void hold()
    {
        // R키를 누르고 있는지 확인
        if (Input.GetKey(KeyCode.R))
        {
            // 누르고 있는 동안 시간을 증가시킴
            holdTime += Time.deltaTime;

            // 누르고 있는 시간이 필요한 시간보다 크거나 같은지 확인
            if (holdTime >= requiredHoldTime)
            {
                // Reset() 메서드 호출
                Reset();
                // holdTime을 초기화하여 Reset()이 다시 호출되지 않도록 함
                holdTime = 0f;
            }
        }
        else
        {
            // R키를 떼면 holdTime을 초기화
            holdTime = 0f;
        }
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

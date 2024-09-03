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
    // RŰ�� ������ �ϴ� �ּ� �ð� (3��)
    public float requiredHoldTime = 3f;
    void hold()
    {
        // RŰ�� ������ �ִ��� Ȯ��
        if (Input.GetKey(KeyCode.R))
        {
            // ������ �ִ� ���� �ð��� ������Ŵ
            holdTime += Time.deltaTime;

            // ������ �ִ� �ð��� �ʿ��� �ð����� ũ�ų� ������ Ȯ��
            if (holdTime >= requiredHoldTime)
            {
                // Reset() �޼��� ȣ��
                Reset();
                // holdTime�� �ʱ�ȭ�Ͽ� Reset()�� �ٽ� ȣ����� �ʵ��� ��
                holdTime = 0f;
            }
        }
        else
        {
            // RŰ�� ���� holdTime�� �ʱ�ȭ
            holdTime = 0f;
        }
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

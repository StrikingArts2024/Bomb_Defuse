using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera_event : MonoBehaviour
{
    public float zoomSpeed = 5f;
    public float minDistance = 5f;
    public float maxDistance = 20f;



    public float updownfil = 0f;
    public float updownCul = 1f;

    public AudioSource clickSound;

    private Camera cameraComponent;



    public GameObject resetButton1;
    public GameObject resetButton2;


    private void Start()
    {
        cameraComponent = GetComponent<Camera>();
        clickSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        float zoomAmount = Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        float distance = cameraComponent.transform.position.z - zoomAmount;

        // 카메라 거리를 minDistance와 maxDistance 범위 안에 유지
        distance = Mathf.Clamp(distance, -maxDistance, -minDistance);

        // 카메라 거리 변경
        cameraComponent.transform.position = new Vector3(cameraComponent.transform.position.x,
                                                         cameraComponent.transform.position.y,
                                                         distance);
        if (Input.GetMouseButtonDown(0))
        {
            click();
        }
    }
    
    void click()
    {
        if (resetButton1.activeSelf == true || resetButton2.activeSelf==true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        // 마우스로 클릭해서 인식 후 대화
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            
            if (hit.transform.gameObject.GetComponent<click_event>() != null)
            {
                clickSound.Play();
                hit.transform.gameObject.GetComponent<click_event>().click();

                
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_event : MonoBehaviour
{
    public float zoomSpeed = 5f;
    public float minDistance = 5f;
    public float maxDistance = 20f;

    private Camera cameraComponent;

    private void Start()
    {
        cameraComponent = GetComponent<Camera>();
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
        // 마우스로 클릭해서 인식 후 대화
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject.GetComponent<click_event>() != null)
            {
                hit.transform.gameObject.GetComponent<click_event>().click();
            }
        }
    }
}

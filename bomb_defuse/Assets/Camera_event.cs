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

        // ī�޶� �Ÿ��� minDistance�� maxDistance ���� �ȿ� ����
        distance = Mathf.Clamp(distance, -maxDistance, -minDistance);

        // ī�޶� �Ÿ� ����
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
        // ���콺�� Ŭ���ؼ� �ν� �� ��ȭ
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

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bomb_mover : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            transform.Rotate(0f, -Input.GetAxis("Mouse X") * speed, 0f, Space.World);
            transform.Rotate(Input.GetAxis("Mouse Y") * speed, 0f, 0f);
        }
    }
}

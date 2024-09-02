using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class minigame_circle : MonoBehaviour
{


    public GameObject point;
    public GameObject circle;
    public int num;
    public bool trig;
    public float randomSeed;


    public void rotate()
    {
        Transform pivot = this.transform.parent.parent;
        Vector3 worldAxis = pivot.TransformDirection(Vector3.back);
        point.transform.RotateAround(this.transform.position, worldAxis, 30* randomSeed * Time.deltaTime);


    }

    // Start is called before the first frame update
    void Start()
    {
        trig = true;
        randomSeed = 1+(Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        if (trig==true)
        {
            rotate();
        }
    }
}

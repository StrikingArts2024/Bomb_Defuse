using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetDisplay : MonoBehaviour, click_event
{


    public void click()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

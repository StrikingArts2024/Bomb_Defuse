using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class minigame_inputbutton : MonoBehaviour,click_event
{
    GameObject master_obj;
    public string character;
    public Material[] mat = new Material[3];


    AudioSource beepSource;
    
    
    public void click()
    {
        float timer=0;
        float waitingTime = 1000f;

        if (character.Equals("start"))
        {
            char[] chars = { 'A', 'B', 'C', 'D' };
            int length = 4;
            string randomString = GenerateRandomString(chars, length);
            master_obj.GetComponent<mini_gameController>().key = randomString;
            master_obj.GetComponent<mini_gameController>().key_inputfield ="";



            StartCoroutine(flashback(randomString));
            
        }
        else
        {
            StartCoroutine(clickflash(this.gameObject));
        }
    }
    IEnumerator clickflash(GameObject obj)
    {
        obj.GetComponent<MeshRenderer>().material = mat[1];
        
        yield return new WaitForSeconds(0.6f);
        obj.GetComponent<MeshRenderer>().material = mat[0];
        yield return new WaitForSeconds(0.2f);



        string str = master_obj.GetComponent<mini_gameController>().key_inputfield;
        master_obj.GetComponent<mini_gameController>().key_inputfield = str + obj.name;
        if (master_obj.GetComponent<mini_gameController>().key_inputfield.Length == 4)
        {
            if (master_obj.GetComponent<mini_gameController>().key_inputfield.Equals(master_obj.GetComponent<mini_gameController>().key)){
                if (master_obj.GetComponent<clear_event>()!=null)
                {
                    master_obj.GetComponent<clear_event>().clear();
                }
            }
            else
            {
                master_obj.GetComponent<mini_gameController>().key_inputfield = null;
            }
        }
        yield return null;
    }
    IEnumerator flashback(String randomString)
    {
        GameObject[] buttonlist = master_obj.GetComponent<mini_gameController>().buttonList;
        for (int i = 0; i < randomString.Length; i++)
        {
            char nowChar = randomString[i];
            int convChar = (int)nowChar - 65;

            GameObject obj = buttonlist[convChar];
            obj.GetComponent<MeshRenderer>().material = mat[2];
            if (beepSource != null)
            {
                beepSource.Play();
            }
            else
            {
                Debug.Log("beep source null");
            }
            yield return new WaitForSeconds(0.6f);
            obj.GetComponent<MeshRenderer>().material = mat[0];
            yield return new WaitForSeconds(0.2f);

        }
        yield return null;
    }
    void Start()
    {
        beepSource = GetComponent<AudioSource>();
        master_obj = this.transform.parent.parent.gameObject;
    }

    string GenerateRandomString(char[] chars, int length)
    {
        System.Text.StringBuilder result = new System.Text.StringBuilder(length);
        System.Random random = new System.Random();

        for (int i = 0; i < length; i++)
        {
            int index = random.Next(chars.Length);
            result.Append(chars[index]);
        }

        return result.ToString();
    }


 

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScript : MonoBehaviour
{
    void Start()
    {
        GetComponent<TIDOU>().enabled = true;
        GetComponent<FIDOU>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown("f")) && (GetComponent<TIDOU>().enabled == true)){
            GetComponent<TIDOU>().enabled = false;
            GetComponent<FIDOU>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
        }else if((Input.GetKeyDown("f")) && (GetComponent<FIDOU>().enabled == true)){
            GetComponent<TIDOU>().enabled = true;
            GetComponent<FIDOU>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }


    }
}

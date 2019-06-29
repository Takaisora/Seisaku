using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScript : MonoBehaviour
{
    void Start()
    {
        GetComponent<FarIDOU>().enabled = true;
        GetComponent<CloseIDOU>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown("f")) && (GetComponent<FarIDOU>().enabled == true)){
            GetComponent<FarIDOU>().enabled = false;
            GetComponent<CloseIDOU>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
        }else if((Input.GetKeyDown("f")) && (GetComponent<CloseIDOU>().enabled == true)){
            GetComponent<FarIDOU>().enabled = true;
            GetComponent<CloseIDOU>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }


    }
}

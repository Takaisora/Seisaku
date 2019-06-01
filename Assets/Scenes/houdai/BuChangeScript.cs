using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuChangeScript : MonoBehaviour
{
    void Start()
    {
        GetComponent<TBullet>().enabled = true;
        GetComponent<FBullet>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown("f")) && (GetComponent<TBullet>().enabled == true)){
            GetComponent<TBullet>().enabled = false;
            GetComponent<FBullet>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
        }else if((Input.GetKeyDown("f")) && (GetComponent<FBullet>().enabled == true)){

            GetComponent<TBullet>().enabled = true;
            GetComponent<FBullet>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }


    }
}

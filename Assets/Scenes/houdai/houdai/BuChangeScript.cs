using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuChangeScript : MonoBehaviour
{
    void Start()
    {
        GetComponent<FarBullet>().enabled = true;
        GetComponent<CloseBullet>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown("f")) && (GetComponent<FarBullet>().enabled == true))
        {
            GetComponent<FarBullet>().enabled = false;
            GetComponent<CloseBullet>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else if((Input.GetKeyDown("f")) && (GetComponent<CloseBullet>().enabled == true))
        {
            this.gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
            GetComponent<FarBullet>().enabled = true;
            GetComponent<CloseBullet>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }


    }
}

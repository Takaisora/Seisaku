using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kirikae : MonoBehaviour
{
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject otherCamera;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //Fキーで切り替え
        if(Input.GetKeyDown("f")){
            mainCamera.SetActive(!mainCamera.activeSelf);
            otherCamera.SetActive(!otherCamera.activeSelf);
        }
    }
}

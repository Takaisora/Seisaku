using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    //回転の中心
    public Transform target;
    //回転速度
    [SerializeField]
    public float speed = 10.0f;
    // Update is called once per frame
    void Update()
    {
        Vector3 axis = transform.TransformDirection(Vector3.forward);

        //if (Input.GetKeyDown(KeyCode.D)){
            transform.RotateAround(target.position, axis, speed * Time.deltaTime);
       // }
    }
}

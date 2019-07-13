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
        var rb = GetComponent<Rigidbody>();
        Quaternion rot = this.gameObject.transform.rotation;
        if (Input.GetKeyDown(KeyCode.D)){
            rb.AddTorque(Vector3.forward * speed * Mathf.PI, ForceMode.Force);
        }

        /*Vector3 axis = transform.TransformDirection(Vector3.forward);

        if (Input.GetKeyDown(KeyCode.D)){
            //Transform.Translate.z += 90;
            transform.RotateAround(target.position, axis, speed);
        }*/
    }
}

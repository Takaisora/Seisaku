using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseIDOU : MonoBehaviour
{/* */
    public float maxangle = 90f;
    public float minangle = -90f;
    Vector2 V1;
    // Start is called before the first frame update
    void Start()
    {
        V1 = new Vector2(transform.localEulerAngles.x, transform.localEulerAngles.y);
        this.gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation = Quaternion.identity;
        float mouseInputX = Input.GetAxis("Mouse X");
        float mouseInputY = Input.GetAxis("Mouse Y");

        V1 = new Vector2(Mathf.Clamp(V1.x - mouseInputY * Time.deltaTime * 200f, minangle, 0), Mathf.Clamp(V1.y + mouseInputX * Time.deltaTime * 200f, minangle, maxangle));
        transform.localEulerAngles = V1;
    }
}

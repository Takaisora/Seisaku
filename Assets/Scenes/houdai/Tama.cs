using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tama : MonoBehaviour
{
    public GameObject bulletpref;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            shot();
        }
    }

    void shot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        bullet = (GameObject)Instantiate(this.bulletpref);
        bullet.transform.position = transform.position;
        bullet.transform.rotation = transform.rotation;

        Vector3 force;
        force = ray.direction * 1000;

        bullet.gameObject.GetComponent<Rigidbody> ().AddForce (force);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject Bullet;
    public Transform Muzzle;
    [SerializeField] public ushort RPM = 120;
    [SerializeField] public float speed = 1000;
    private float _tmpfire = 0;
    private float _lastfired = 0;
    Vector3 force;

    void Start()
    {
        _tmpfire = RPM / 60.0f;
    }
    void shot()
    {
        GameObject Bullets = Instantiate(Bullet) as GameObject;
        force = this.gameObject.transform.forward * speed;
        Bullets.GetComponent<Rigidbody>().AddForce(force);
        Bullets.transform.position = Muzzle.position;
        Destroy(Bullets, 3.0f);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time - _lastfired > 1 / _tmpfire)
        {
            _lastfired = Time.time;
            shot();
        }
        
    }
}

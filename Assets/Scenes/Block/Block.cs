using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        //衝突判定　相手のタグがBulletなら消す
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }

    }
}

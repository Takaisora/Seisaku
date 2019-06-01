using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIDOU : MonoBehaviour
{/*
    //最大角度
    public float maxangle = 90f;
    //最小角度
    public float minangle = -90f;
    Vector2 V1;
    // Start is called before the first frame update
    void Start()
    {
        V1 = new Vector2(0f, transform.localEulerAngles.y);//Vector2の設置　X軸は動かさない
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation = Quaternion.identity;//角度うんぬん
        float mouseInputX = Input.GetAxis("Mouse X");//マウスのX軸を取り込む
        float mouseInputY = Input.GetAxis("Mouse Y");//マウスのY軸を取り込む　Fの遺産

        //Xは0固定　
        V1 = new Vector2(0f, Mathf.Clamp(V1.y + mouseInputX * Time.deltaTime * 200f, minangle, maxangle));
        transform.localEulerAngles = V1;
    }
*/  Plane plane = new Plane();
	float distance = 0;


	void Update()
	{
		// カメラとマウスの位置を元にRayを準備
		var ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		// プレイヤーの高さにPlaneを更新して、カメラの情報を元に地面判定して距離を取得
		plane.SetNormalAndPosition (Vector3.up, transform.localPosition);
		if (plane.Raycast (ray, out distance)) {

			// 距離を元に交点を算出して、交点の方を向く
			var lookPoint = ray.GetPoint(distance);
			transform.LookAt (lookPoint);
		}
	}
}

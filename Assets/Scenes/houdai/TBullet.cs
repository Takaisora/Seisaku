using UnityEngine;
using System.Collections;

public class TBullet : MonoBehaviour {

	//　弾のゲームオブジェクト
	[SerializeField]
	private GameObject bulletPrefab;
	//　銃口
	[SerializeField]
	private Transform muzzle;
	//　弾を飛ばす力
	[SerializeField]
	private float bulletPower = 500f;

	void Start () {

    }

	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		transform.rotation = Quaternion.LookRotation(ray.direction);

		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, 1f, LayerMask.GetMask ("Gun"))) {
			Cursor.visible = false;
		} else {
			Cursor.visible = true;
		}

		//　マウスの左クリックで撃つ
		if(Input.GetButtonDown("Fire1")) {
			Shot();
		}
	}

	//　敵を撃つ
	void Shot() {
		var bulletInstance = GameObject.Instantiate(bulletPrefab, muzzle.position, muzzle.rotation) as GameObject;
		bulletInstance.GetComponent<Rigidbody>().AddForce(bulletInstance.transform.up * bulletPower);
		Destroy(bulletInstance, 5f);
	}
}
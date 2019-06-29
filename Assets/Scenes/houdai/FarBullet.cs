using UnityEngine;
using System.Collections;

public class FarBullet : MonoBehaviour {

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
		//　マウスの左クリックで撃つ
		if(Input.GetButtonDown("Fire1")) {
			Shot();
		}
	}

	//　敵を撃つ
	void Shot() {
		var bulletInstance = GameObject.Instantiate(bulletPrefab, muzzle.position, muzzle.rotation) as GameObject;
		bulletInstance.GetComponent<Rigidbody>().AddForce(bulletInstance.transform.forward * bulletPower);
		Destroy(bulletInstance, 5f);
	}
}
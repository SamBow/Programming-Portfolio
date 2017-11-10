using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {

	private bool canShoot = true;
	public Transform enemyBullet;
	public GameObject bulletSpawn;

	void Start () {
		canShoot = false;
		StartCoroutine("WaitToShoot");
	}
	
	void Update () {
		Shoot();
	}

	void Shoot() {
		if(canShoot == true) {
			Instantiate(enemyBullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
			canShoot = false;
			StartCoroutine("WaitToShoot");
		}
	}

	IEnumerator WaitToShoot() {
		Debug.Log("before");
		yield return new WaitForSeconds(3);
		canShoot = true;
		Debug.Log("after");
	}
}

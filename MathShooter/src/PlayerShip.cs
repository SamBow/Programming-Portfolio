using UnityEngine;
using System.Collections;

public class PlayerShip : MonoBehaviour {

	private Rigidbody2D rigid;
	private Animator anim;

	public Transform player;
	public float horizontalSpeed;
	public float verticalSpeed;
	public float respawnTime;
	private bool canShoot = true;
	private bool canMove;
	public float moveTime;

	public Transform playerBullet1;
	public GameObject bulletSpawn1;
	public Transform playerBullet2;
	public GameObject bulletSpawn2;

	void Start () {
		rigid = GetComponent<Rigidbody2D>();
	}

	void Update () {
		if(moveTime >= 0) {
			moveTime -= Time.deltaTime * 1;
			canMove = false;
		}
		if(moveTime <= 0) {
			canMove = true;
		}

		Move();
		Shoot();
	}

	void Move() {
		//Keycodes are preset by Unity
		if(Input.GetAxisRaw("Horizontal") > .5f || Input.GetAxisRaw("Horizontal") < -.5f) {
			rigid.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * horizontalSpeed, verticalSpeed);
		}
		
		//Stops player with rigidbody
		if(Input.GetAxisRaw("Horizontal") < .5f && Input.GetAxisRaw("Horizontal") > -.5f) {
			rigid.velocity = new Vector2(0f, verticalSpeed);
		}
	}

	void Shoot() {
		if(canShoot == true) {
			if(Input.GetKeyDown("space")) {
				Instantiate(playerBullet1, bulletSpawn1.transform.position, bulletSpawn1.transform.rotation);
				Instantiate(playerBullet2, bulletSpawn2.transform.position, bulletSpawn2.transform.rotation);
				canShoot = false;
				StartCoroutine("WaitToShoot");
			}
		}
	}

	IEnumerator WaitToShoot() {
		Debug.Log("before");
		yield return new WaitForSeconds(1);
		canShoot = true;
		Debug.Log("after");
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "death") {
			Application.LoadLevel(Application.loadedLevel);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if(coll.gameObject.name == "Boss") {
			Application.LoadLevel("Subtraction1");
		}
	}
}


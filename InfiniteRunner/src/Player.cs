using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

	public Transform player;

	public float jumpHeight;
	private float moveSpeed = 12.3f;

	private bool canJump;

	private Rigidbody2D rigid;

	void Start () {
		rigid = GetComponent<Rigidbody2D>();

		player = GameObject.FindWithTag("player").transform;

		canJump = true;
	}
	
	void Update () {
		Move();
	}

	public void Move() {
		rigid.velocity = new Vector2(moveSpeed, rigid.velocity.y);

		if(Input.GetKeyDown(KeyCode.Space) && canJump == true) {
			rigid.velocity = new Vector2(rigid.velocity.x, jumpHeight);
			canJump = false;
		}
		if(player.position.y < -10) {
			Application.LoadLevel(Application.loadedLevel);
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if(collision.gameObject.tag == "platform") {
			canJump = true;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "bully") {
			Application.LoadLevel("BossFight");
		}
	}
}

using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	private Rigidbody2D rigid;

	public float moveSpeed;

	void Start () {
		rigid = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
		Move();
	}

	void Move() {
		rigid.velocity = new Vector2(rigid.velocity.x, moveSpeed);
	}
}

using UnityEngine;
using System.Collections;

public class Bully : MonoBehaviour {

	private float moveSpeed = 12f;

	private Rigidbody2D rigid;
	
	void Update () {

		gameObject.transform.position = new Vector2(transform.position.x + .20f, transform.position.y);
	}
}

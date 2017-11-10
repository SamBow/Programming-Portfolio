using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour {

	private Rigidbody2D rigid;

	public float moveSpeed;

	public float liveTime;

	void Start () {
		rigid = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
		Move();
		Destroy();
	}

	void Move() {
		rigid.velocity = new Vector2(rigid.velocity.x, moveSpeed);
	}

	void Destroy() {
		if(liveTime >= 0) {
			liveTime -= Time.deltaTime * 1;
		}
		if(liveTime <= 0) {
			Destroy(this.gameObject);
		}
	}
}

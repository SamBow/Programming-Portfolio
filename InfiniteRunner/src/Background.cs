using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

	public Transform player;
	public float speed = .5f;
	private Rigidbody2D rigid;

	void Start () {
		rigid = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
		player = GameObject.FindWithTag("player").transform;

		Vector2 a = new Vector2(Time.time * speed, 0);

		GetComponent<Renderer>().material.mainTextureOffset = a;

		transform.position = new Vector2(player.transform.position.x, transform.position.y);

	}
}

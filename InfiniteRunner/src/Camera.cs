using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	public Transform camera;
	public Transform player;
	public float cameraY;

	void Start () {
		player = GameObject.FindWithTag("player").transform;
	}
	
	void Update () {
		camera.position = new Vector3(player.position.x, cameraY, -25);
	}
}

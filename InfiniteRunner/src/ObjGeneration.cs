using UnityEngine;
using System.Collections;

public class ObjGeneration : MonoBehaviour {

	public Transform player;
	public Transform SP;
	public Transform obj;

	public float spawnDistance;
	public float valueY;

	public bool destroy;

	void Start () {
		player = GameObject.FindWithTag("player").transform;
	}
	
	void Update () {
		Generate();
	}

	public void Generate() {
		if(player.position.x > SP.position.x) {
			SP.position = new Vector3(transform.position.x + spawnDistance, transform.position.y, transform.position.z);

			Instantiate(obj, new Vector3(SP.position.x + 10, valueY, 0), transform.rotation);
		}
	}
}

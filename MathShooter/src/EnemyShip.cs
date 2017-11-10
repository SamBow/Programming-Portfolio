using UnityEngine;
using System.Collections;

public class EnemyShip : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "bullet") {
			Destroy(this.gameObject);
			Destroy(other.gameObject);
		}
	}
}

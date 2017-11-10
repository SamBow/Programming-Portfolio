using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	public Transform target;
	public float speed;

	void Start () {
	}
	
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, target.position, speed);
	}

}

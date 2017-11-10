using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject sp1;
	public GameObject sp2;
	public Transform ship;
	private int randNum;

	void Start () {
		Spawn();
	}

	void Spawn() {
		StartCoroutine(GenerateShip());
	}

	public IEnumerator GenerateShip() {
		randNum = Random.Range(0,2);
		yield return new WaitForSeconds(Random.Range(10f, 12f));
		if(randNum == 1) {
			Instantiate(ship, sp1.transform.position, Quaternion.identity);
		} else {
			Instantiate(ship, sp2.transform.position, Quaternion.identity);
		}
		Spawn();
	}
}

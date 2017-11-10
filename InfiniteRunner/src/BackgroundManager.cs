using UnityEngine;
using System.Collections;

public class BackgroundManager : MonoBehaviour {

	private int randNum;
	public Material[] backgrounds;
	private Material material;

	void Start () {
		randNum = Random.Range(1,3);

		switch(randNum) {
			case 1:
				GetComponent<Renderer>().material = backgrounds[0];
				break;
			case 2:
				GetComponent<Renderer>().material = backgrounds[1];
				break;
			default:
				break;
		}
	}
	
	void Update () {
	}

}

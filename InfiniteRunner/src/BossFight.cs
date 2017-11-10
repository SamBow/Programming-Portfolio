using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BossFight : MonoBehaviour {

	void Start () {

	}
	
	void Update () {
		
	}

	public void Run() {
		Application.LoadLevel("InfiniteRunner");

	}

	public void Help() {
		Application.LoadLevel("EndScreen");
	}

	public void Play() {
		Application.LoadLevel("InfiniteRunner");
	}
}

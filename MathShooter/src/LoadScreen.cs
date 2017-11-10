using UnityEngine;
using System.Collections;

public class LoadScreen : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}

	public void ChangeScene(string sceneName) {
		Application.LoadLevel(sceneName);
	}
}

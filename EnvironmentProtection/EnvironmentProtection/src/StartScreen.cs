using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}

	public void LoadScene(string sceneName) { Application.LoadLevel(sceneName); }

	public void Quit() { Application.Quit(); }
}

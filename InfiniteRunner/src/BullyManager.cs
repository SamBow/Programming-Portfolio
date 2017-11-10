using UnityEngine;
using System.Collections;

public class BullyManager : MonoBehaviour {

	public static int counter;
	public float xvalue;

	private static Manager instace = null;

	private bool active;

	private Transform sprRender;
	public Transform[] objects;

	public static Manager Instance{
		get {
			return instace;
		}
	}

	void Start() {
		active = true;
		for(int i = 0; i < objects.Length; i++) {
			sprRender = objects[counter];
			if(active == true) {
				Instantiate(sprRender, new Vector3(xvalue, 4, 0), Quaternion.identity);
				active = false;
			}
		}
	}

	void Awake() {
		DontDestroyOnLoad(this.gameObject);
		Count();
		Debug.Log(counter);
	}

	public int Count() {
		counter += 1;
		if(counter >= objects.Length) {
			counter -= 4;
		}
		return counter;
	}
}

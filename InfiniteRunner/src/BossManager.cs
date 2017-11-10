using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BossManager : MonoBehaviour {

	public static int counter;

	private static BossManager instace = null;

	private bool active;

	private Image img;

	private Sprite sprRender;
	public Sprite[] objects;

	public static BossManager Instance{
		get {
			return instace;
		}
	}

	void Start() {
		img = GameObject.FindWithTag("image").GetComponent<Image>();

		active = true;
		for(int i = 0; i < objects.Length; i++) {
			sprRender = objects[counter];
			if(active == true) {
				img.sprite = sprRender;
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
			Application.LoadLevel("EndScreen");
		}
		return counter;
	}
}

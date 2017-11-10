using UnityEngine;
using System.Collections;


public class OilRig : MonoBehaviour {

	public Sprite stage1;
	public Sprite stage2;
	public Sprite stage3;
	public Sprite stage4;
	public Sprite stage5;

	public GameObject Oil;

	private SpriteRenderer spriteRenderer;

	void Start () {
		Oil.SetActive(false);

		spriteRenderer = GetComponent<SpriteRenderer>();
		spriteRenderer.sprite = stage1;
	}
	
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D coll) {
		if(coll.gameObject.tag == "Ship") {
			Drill();
			Destroy(coll.gameObject);
		}
	}

	public void Drill() {
		if(spriteRenderer.sprite == stage1) {
			spriteRenderer.sprite = stage2;
		} else if(spriteRenderer.sprite == stage2) {
			spriteRenderer.sprite = stage3;
		} else if(spriteRenderer.sprite == stage3) {
			spriteRenderer.sprite = stage4;
		} else if(spriteRenderer.sprite == stage4) {
			spriteRenderer.sprite = stage5;
			Spill();
		}
	}

	public void Spill() {
		Oil.SetActive(true);
		StartCoroutine(EndGame());
	}

	public IEnumerator EndGame() {
		yield return new WaitForSeconds(50);
		Application.LoadLevel("EndGame");
	}
}

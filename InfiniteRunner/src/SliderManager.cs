using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour {

	public Slider slider;

	void Start () {
		
	}
	
	void Update () {
		slider.value++;

		if(slider.value == slider.maxValue) {
			Application.LoadLevel("BossFight");
		}
	}


}

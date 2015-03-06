using UnityEngine;
using System.Collections;

public class ColorToTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		iTween.ColorTo( gameObject, iTween.Hash(
			"color", Color.yellow , 
			"easeType", "easeInOutExpo", 
			"loopType", "pingPong",
			"delay", 
			.1));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

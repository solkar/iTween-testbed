using UnityEngine;
using System.Collections;

public class ColorFromTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		iTween.ColorFrom( gameObject, iTween.Hash(
			"color", Color.cyan , 
			"easeType", "easeInOutExpo", 
			"loopType", "pingPong",
			"includechildren" , true,
			"delay", 
			.1));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

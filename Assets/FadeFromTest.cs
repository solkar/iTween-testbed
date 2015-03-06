using UnityEngine;
using System.Collections;

public class FadeFromTest : MonoBehaviour {

	void Start(){
		iTween.FadeFrom(gameObject, iTween.Hash( "alpha" , 0.0f ,  "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", .1));
	}
}

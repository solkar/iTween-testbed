using UnityEngine;
using System.Collections;

public class PunchRotationTest : MonoBehaviour {

	void Start(){
		iTween.PunchRotation(gameObject, iTween.Hash( "y" ,  90.0f , "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", .1));
	}

}

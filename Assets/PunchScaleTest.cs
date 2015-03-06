using UnityEngine;
using System.Collections;

public class PunchScaleTest : MonoBehaviour {

	void Start(){
		iTween.PunchScale(gameObject, iTween.Hash( "y" ,  2.0f , "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", .1));
	}

}

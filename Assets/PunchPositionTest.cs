using UnityEngine;
using System.Collections;

public class PunchPositionTest : MonoBehaviour {

	void Start(){
		iTween.PunchPosition(gameObject, iTween.Hash( "y" ,  2 , "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", .1));
	}

}

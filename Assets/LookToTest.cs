using UnityEngine;
using System.Collections;

public class LookToTest : MonoBehaviour {

	public Transform target;

	void Start(){
		iTween.LookTo(gameObject, iTween.Hash( "looktarget" , target , 
		                                        "time" , 1.0f,
		                                        "easeType", "easeInOutExpo", 
		                                        "loopType", "pingPong", 
		                                        "delay", .1));
	}
}

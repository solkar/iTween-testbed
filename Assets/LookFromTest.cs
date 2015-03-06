using UnityEngine;
using System.Collections;

public class LookFromTest : MonoBehaviour {

	public Transform target;

	void Start(){
		iTween.LookFrom(gameObject, iTween.Hash( "looktarget" , target , 
		                                        "time" , 1.0f,
		                                        "easeType", "easeInOutExpo", 
		                                        "loopType", "pingPong", 
		                                        "delay", .1));
	}
}

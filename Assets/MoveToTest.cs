using UnityEngine;
using System.Collections;

public class MoveToTest : MonoBehaviour {

	void Start(){
		iTween.MoveTo(gameObject, iTween.Hash( "position" ,  new Vector3( 3 , 3 , 3 ) , "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", .1));
	}
}

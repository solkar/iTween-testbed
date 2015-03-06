using UnityEngine;
using System.Collections;

public class RotateFromSample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.RotateFrom( gameObject , iTween.Hash( "y" , 80 , "delay" , 0.1f , "easetype" , "easeInOutSin" , "looptype" , "loop" ) );
	}
	
}


using UnityEngine;
using System.Collections;

public class RotateBySample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.RotateBy( gameObject , iTween.Hash( "y" , 30 , "delay" , 0.1f , "easetype" , "easeInOutSin" , "looptype" , "loop" ) );
	}

}

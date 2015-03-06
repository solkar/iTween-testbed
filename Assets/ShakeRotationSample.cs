using UnityEngine;
using System.Collections;

public class ShakeRotationSample : MonoBehaviour {

	void Start () {
		iTween.ShakeRotation( gameObject , iTween.Hash( "z" , 30.0f , "delay" , 0.1f , "easetype" , "easeInOutSin" , "looptype" , "pingPong" ) );
	}
}

using UnityEngine;
using System.Collections;

public class ScaleBySample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.ScaleBy( gameObject , iTween.Hash( "y" , 2.0f , "delay" , 0.1f , "easetype" , "easeInOutSin" , "looptype" , "pingPong" ) );
	}
}

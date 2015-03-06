using UnityEngine;
using System.Collections;

public class ShakeScaleSample : MonoBehaviour {

	void Start () {
		iTween.ShakeScale( gameObject , iTween.Hash( "y" , 1.0f , "delay" , 0.1f , "easetype" , "easeInOutSin" , "looptype" , "pingPong" ) );
	}
}

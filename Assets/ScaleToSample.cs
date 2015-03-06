using UnityEngine;
using System.Collections;

public class ScaleToSample : MonoBehaviour {

	void Start () {
		iTween.ScaleTo( gameObject , iTween.Hash( "y" , -2.5f , "delay" , 0.1f , "easetype" , "easeInOutSin" , "looptype" , "pingPong" ) );
	}
}

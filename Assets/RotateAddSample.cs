using UnityEngine;
using System.Collections;

public class RotateAddSample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.RotateAdd( gameObject , iTween.Hash( "y" , 30 , "delay" , 0.1f , "easetype" , "easeInOutSin" , "looptype" , "pingPong" ) );
	}
	

}

using UnityEngine;
using System.Collections;

public class ScaleAddSample : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		iTween.ScaleAdd( gameObject , iTween.Hash( "y" , 2.0f , "delay" , 0.1f , "easetype" , "easeInOutSin" , "looptype" , "pingPong" ) );
	}
	
}


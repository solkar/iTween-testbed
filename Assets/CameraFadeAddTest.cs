using UnityEngine;
using System.Collections;

public class CameraFadeAddTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

		var hash = iTween.Hash( 
		            "amount", 	1.0f , 
		            "time", 	5.0f,
		                       "oncomplete" , "Complete" );

		iTween.CameraFadeAdd();

		iTween.CameraFadeFrom( hash );

	}
	
	// not called
	void Complete () {
		iTween.CameraFadeDestroy();
	}
}

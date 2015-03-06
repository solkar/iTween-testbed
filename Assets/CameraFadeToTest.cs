using UnityEngine;
using System.Collections;

public class CameraFadeToTest : MonoBehaviour {

	// FadeIn to black
	void Start () {

		var hash = iTween.Hash( 
		            "amount", 	1.0f , 
		            "time", 	5.0f,
		                       "oncomplete" , "Complete" );

		iTween.CameraFadeAdd();

		iTween.CameraFadeTo( hash ); 

	}
	
	// not called
	void Complete () {
		iTween.CameraFadeDestroy();
	}
}

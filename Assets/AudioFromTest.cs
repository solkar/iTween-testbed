using UnityEngine;
using System.Collections;

public class AudioFromTest : MonoBehaviour 
{

	void Start(){
		iTween.AudioFrom(gameObject, iTween.Hash( 
		                                         "volume", 	1.0f , 
		                                         "pitch", 	3.0f , 
		                                         "delay", 	0.1f,
		                                         "looptype", "pingPong",
		                                         "onstart" , "PlaySound" ) );
	
	}

	void PlaySound()
	{
		audio.Play ();
	}
}

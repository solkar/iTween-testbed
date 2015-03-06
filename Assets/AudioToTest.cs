using UnityEngine;
using System.Collections;

public class AudioToTest : MonoBehaviour 
{

	void Start(){
		iTween.AudioFrom(gameObject, iTween.Hash( 
		                                         "volume", 	1.0f , 
		                                         "pitch", 	0.5f , 
		                                         "delay", 	0.3f,
		                                         "looptype", "pingPong",
		                                         "onstart" , "PlaySound" ) );
	
	}

	void PlaySound()
	{
		audio.Play ();
	}
}

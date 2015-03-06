using UnityEngine;
using System.Collections;

public class StabSample : MonoBehaviour {

	void Start () {
		iTween.Stab( gameObject , iTween.Hash( "audioclip" , audio.clip , "volume" , 1.0f , "pitch" , 1.0f , "delay" , 0.1f , "looptype" , "pingPong" ) );
	}
}

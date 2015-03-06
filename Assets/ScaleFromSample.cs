using UnityEngine;
using System.Collections;

public class ScaleFromSample : MonoBehaviour {

	void Start () {
		iTween.ScaleFrom( gameObject , iTween.Hash( "y" , 2.5f , "delay" , 0.1f , "easetype" , "easeInOutSin" , "looptype" , "pingPong" ) );
	}
}

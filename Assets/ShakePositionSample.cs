using UnityEngine;
using System.Collections;

public class ShakePositionSample : MonoBehaviour {

	void Start () {
		iTween.ShakePosition( gameObject , iTween.Hash( "y" , 1.0f , "delay" , 0.1f , "easetype" , "easeInOutBounce" , "looptype" , "pingPong" ) );
	}
}

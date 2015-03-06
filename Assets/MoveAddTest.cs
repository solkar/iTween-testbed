using UnityEngine;
using System.Collections;

public class MoveAddTest : MonoBehaviour {

	void Start(){
		iTween.MoveAdd(gameObject, iTween.Hash("y", 2, "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", .1));
	}
}

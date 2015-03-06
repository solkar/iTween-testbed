using UnityEngine;
using System.Collections;

public class DrawLineTest : MonoBehaviour {

	public Transform[] path;


	void OnDrawGizmos()
	{
		iTween.DrawLine( path , Color.red );
	}
	
}

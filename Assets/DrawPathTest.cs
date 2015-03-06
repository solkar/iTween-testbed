using UnityEngine;
using System.Collections;

public class DrawPathTest : MonoBehaviour {

	public Transform[] path;
	

	void OnDrawGizmos()
	{
		iTween.DrawPath( path , Color.red );

		Debug.Log( "Path length: " + iTween.PathLength( path ) );

	}
	
}

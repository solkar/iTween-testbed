using UnityEngine;
using System.Collections;

public class DrawLineHandlesTest : MonoBehaviour {

	public Transform[] path;


	void OnDrawGizmos()
	{
		iTween.DrawLineHandles( path , Color.black );
	}
	
}

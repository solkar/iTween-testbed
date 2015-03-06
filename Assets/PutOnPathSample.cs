using UnityEngine;
using System.Collections;

public class PutOnPathSample : MonoBehaviour {

	public Transform[] path;

	private float easen = 0.0f;

	void Start(){
		iTween.PutOnPath( gameObject, path , 0.5f );
	}

	void Update()
	{
		easen = iTween.FloatUpdate( easen , 1.0f , 1.0f );
		iTween.PutOnPath( gameObject, path , easen  );

		if( easen >= 0.98f )
		{
			easen = 0;
		}
	}

	void OnDrawGizmos()
	{
		iTween.DrawLine( path , Color.red );
	}
}

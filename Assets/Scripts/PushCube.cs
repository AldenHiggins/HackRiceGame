using UnityEngine;
using System.Collections;

public class PushCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Collider[] colliders;
		Rigidbody rigidbody;

		//print ("Made a magnetic cube.");
		colliders = Physics.OverlapSphere (transform.position , 8f);
		foreach (Collider collider in colliders)
		{
			//print ("GameObject is  " + collider.gameObject.name);
			if (collider.gameObject.name == "CubeBullet(Clone)") {
//				float distance = Vector3.Distance (collider.gameObject.transform.position, transform.position);

				rigidbody = (Rigidbody)collider.gameObject.GetComponent (typeof(Rigidbody));
				if (rigidbody == null) {
					continue;
				}
				//print ("Found a rigidbody");
				rigidbody.AddExplosionForce (10f * 1, transform.position, 8f);

			}
		}
	}
}

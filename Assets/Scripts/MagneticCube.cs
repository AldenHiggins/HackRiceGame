using UnityEngine;
using System.Collections;

public class MagneticCube : MonoBehaviour {

	//private Vector3 force = new Vector3 (3, 0, 0);

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Collider[] colliders;
		Rigidbody rigidbody;

		//print ("Made a magnetic cube.");
		colliders = Physics.OverlapSphere (transform.position , 20f);
		foreach (Collider collider in colliders)
		{
			//print ("GameObject is  " + collider.gameObject.name);
			if (collider.gameObject.name == "CubeBullet(Clone)") {
				float distance = Vector3.Distance (collider.gameObject.transform.position, transform.position);
				if (distance > 2f) {


					rigidbody = (Rigidbody)collider.gameObject.GetComponent (typeof(Rigidbody));
					if (rigidbody == null) {
						continue;
					}
					//print ("Found a rigidbody");
					rigidbody.AddExplosionForce (100f * -1, transform.position, 20f);
				}
			}
		}

	}
}

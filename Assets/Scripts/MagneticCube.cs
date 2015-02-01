using UnityEngine;
using System.Collections;

public class MagneticCube : MonoBehaviour {

	//private Vector3 force = new Vector3 (3, 0, 0);

	// Use this for initialization
	void Start () {
//		Collider[] colliders;
//		Rigidbody rigidbody;
//
//		print ("Made a magnetic cube.");
//		colliders = Physics.OverlapSphere (transform.position , 120f);
//		foreach (Collider collider in colliders)
//		{
//			print ("Found a collider");
//			rigidbody = (Rigidbody) collider.gameObject.GetComponent (typeof (Rigidbody));
//			if (rigidbody == null)
//			{
//				continue;
//			}
//			print ("Found a rigidbody");
//			rigidbody.AddExplosionForce (5f * -1, transform.position, 20f);
//
//		}

	}
	
	// Update is called once per frame
	void Update () {
		//Destroy(GameObject, 3);
		Collider[] colliders;
		Rigidbody rigidbody;

		print ("Made a magnetic cube.");
		colliders = Physics.OverlapSphere (transform.position , 120f);
		foreach (Collider collider in colliders)
		{
			print ("Found a collider");
			rigidbody = (Rigidbody) collider.gameObject.GetComponent (typeof (Rigidbody));
			if (rigidbody == null)
			{
				continue;
			}
			print ("Found a rigidbody");
			rigidbody.AddExplosionForce (100f * -1, transform.position, 20f);

		}
	}
}

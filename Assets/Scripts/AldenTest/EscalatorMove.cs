using UnityEngine;
using System.Collections;

public class EscalatorMove : MonoBehaviour 
{
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.name == "CubeBullet(Clone)")
		{
			print ("Entered this collider");
			print (transform.forward);
			other.rigidbody.velocity += transform.forward * 4f;
		}

	}
}
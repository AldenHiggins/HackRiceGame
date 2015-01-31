using UnityEngine;
using System.Collections;

public class TimerExplode : MonoBehaviour {

	bool expired = false;

	// Use this for initialization
	void Start () {
		StartCoroutine("Timer");
	}
	
	// Update is called once per frame
	void Update () {
		if (expired) {
			// Create the explosion's particle effect
			Instantiate (explosion, transform.position, Quaternion.identity);
			
			// Create an explosion around where the player aims
			Collider[] colliders = Physics.OverlapSphere(hit.point, radius);
			
			foreach(Collider collider in colliders)
			{
				if (collider.rigidbody == null)
					continue;
				collider.rigidbody.AddExplosionForce(force, hit.point, radius, 0.0f, ForceMode.Impulse);
			}

			// Destroy this object
			Destroy (gameObject);
		}
	}

	// Coroutine to count until the cube explodes
	IEnumerator Timer() {
		for (int i = 0; i< 1000; i++) {
			if (i == 999){
				expired = true;
			}
			yield return null;
		}
	}
}

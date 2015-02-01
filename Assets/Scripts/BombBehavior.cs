using UnityEngine;
using System.Collections;

public class BombBehavior : MonoBehaviour {
	
	public float force;
	public float radius;
	public GameObject player;
	public GameObject explosion;
	public int fuse;
	
	private bool expired = false;
	
	// Use this for initialization
	void Start () {
		StartCoroutine ("Timer");
	}
	
	// Update is called once per frame
	void Update () {
		if (expired) {
			
			// Create the explosion's particle effect
			Instantiate (explosion, transform.position, Quaternion.identity);
			
			// Create an explosion around where the player aims
			Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
			
			foreach(Collider collider in colliders)
			{
				if (collider.rigidbody == null)
					continue;
				collider.rigidbody.AddExplosionForce(force, transform.position, radius, 0.0f, ForceMode.Impulse);
			}
			
			Destroy (gameObject);
		}
	}
	
	IEnumerator Timer() {
		for (int i = 0; i < fuse; i++){
			if (i == fuse-1){
				expired = true;
			}
			yield return null;
		}
	}
}


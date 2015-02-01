using UnityEngine;
using System.Collections;

public class CubeCollider : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
	}
	// Destroy everything that enters the trigger
	void OnTriggerEnter (Collider other)
	{
		Destroy (other);
		Debug.Log ("You have sent a cube through the wormhole! :)");
	}
	
}


using UnityEngine;
using System.Collections;

public class Projectiles : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public GameObject cubeProjectile;
	public GameObject player;
	public GameObject cubeMagnet;

	private GameObject cubeProjectileObject;
	private bool previousBDown = false;
	private bool previousXDown = false;
	private bool previousYDown = false;

	// Update is called once per frame
	void Update () {
		bool bPressed = OVRGamepadController.GPC_GetButton(OVRGamepadController.Button.B);

		// Create projectile
		if (bPressed && !previousBDown)
		{
			cubeProjectileObject = (GameObject) Instantiate (cubeProjectile);
		}
		// Animate projectile in front of player
		else if (bPressed)
		{
			print ("B being pressed");
			cubeProjectileObject.transform.position = player.transform.position + 2 * player.transform.forward;
			cubeProjectileObject.transform.Rotate (new Vector3(15, 30, 35) * Time.deltaTime);
		}
		// Fire projectile
		else if (!bPressed && previousBDown)
		{
			print ("B released");
			cubeProjectileObject.rigidbody.velocity += 8 * player.transform.forward;
		}

		previousBDown = bPressed;

		//Bomb Projectile
		bool xPressed = OVRGamepadController.GPC_GetButton(OVRGamepadController.Button.X);
		
		// Create projectile
		if (xPressed && !previousXDown)
		{
			//cubeProjectileObject = (GameObject) Instantiate (cubeBomb);

		}
		// Animate projectile in front of player
		else if (xPressed)
		{
			print ("X being pressed");
			cubeProjectileObject.transform.position = player.transform.position + 2 * player.transform.forward;
			cubeProjectileObject.transform.Rotate (new Vector3(15, 30, 35) * Time.deltaTime);
		}
		// Fire projectile
		else if (!xPressed && previousXDown)
		{
			print ("X released");
			cubeProjectileObject.rigidbody.velocity += 8 * player.transform.forward;
		}
		
		previousXDown = xPressed;


		// Attaching the Y button to Magnetic Cube
		bool yPressed = OVRGamepadController.GPC_GetButton(OVRGamepadController.Button.Y);

		// Create projectile
		if (yPressed && !previousYDown)
		{
			cubeProjectileObject = (GameObject) Instantiate (cubeMagnet);
		}
		// Animate projectile in front of player
		else if (yPressed)
		{
			print ("Y being pressed");
			cubeProjectileObject.transform.position = player.transform.position + 2 * player.transform.forward;
			cubeProjectileObject.transform.Rotate (new Vector3(15, 30, 35) * Time.deltaTime);
		}
		// Fire projectile
		else if (!yPressed && previousYDown)
		{
			print ("Y released");
			cubeProjectileObject.rigidbody.velocity += 8 * player.transform.forward;
		}

		previousYDown = yPressed;

	}

}

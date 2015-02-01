using UnityEngine;
using System.Collections;

public class Projectiles : MonoBehaviour {

	private GameLogic game;
	// Use this for initialization
	void Start () 
	{
		game = (GameLogic) transform.gameObject.GetComponent (typeof(GameLogic));
	}


	public GameObject player;

	public GameObject cubeProjectile;
	public GameObject cubeMagnet;
	public GameObject cubePush;
	public GameObject cubeBomb;

	private GameObject cubeProjectileObject;
	private bool previousBDown = false;
	private bool previousXDown = false;
	private bool previousRBDown = false;
	private bool previousLBDown = false;


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
			player.audio.Play();
		}

		previousBDown = bPressed;

		//Bomb Projectile
		bool xPressed = OVRGamepadController.GPC_GetButton(OVRGamepadController.Button.X);
		
		// Create projectile
		if (xPressed && !previousXDown)
		{
			if (game.getPushBlocksLeft() > 0)
			{
				game.placePushBlock();
				cubeProjectileObject = (GameObject) Instantiate (cubePush);
			}
			else
			{
				xPressed = false;
			}
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
			player.audio.Play();
		}
		
		previousXDown = xPressed;


		// Attaching the Y button to Magnetic Cube
		bool rbPressed = OVRGamepadController.GPC_GetButton(OVRGamepadController.Button.RightShoulder);

		// Create projectile
		if (rbPressed && !previousRBDown)
		{
			if (game.getPullBlocksLeft() > 0)
			{
				game.placePullBlock();
//				cubeProjectileObject = (GameObject) Instantiate (cubePush);
				cubeMagnet = (GameObject) Instantiate (cubeMagnet);
			}
			else
			{
				rbPressed = false;
			}

		}
		// Animate projectile in front of player
		else if (rbPressed)
		{
			print ("RB being pressed");
			cubeMagnet.transform.position = player.transform.position + 2 * player.transform.forward;
			cubeMagnet.transform.Rotate (new Vector3(15, 30, 35) * Time.deltaTime);
		}
		// Fire projectile
		else if (!rbPressed && previousRBDown)
		{
			print ("RB released");
			cubeMagnet.rigidbody.velocity += 1 * player.transform.forward;
		}

		previousRBDown = rbPressed;

		// Attaching the Y button to Magnetic Cube
		bool lbPressed = OVRGamepadController.GPC_GetButton(OVRGamepadController.Button.LeftShoulder);
		
		// Create projectile
		if (lbPressed && !previousLBDown)
		{
			cubeMagnet = (GameObject) Instantiate (cubeBomb);
		}
		// Animate projectile in front of player
		else if (lbPressed)
		{
			print ("LB being pressed");
			cubeMagnet.transform.position = player.transform.position + 2 * player.transform.forward;
			cubeMagnet.transform.Rotate (new Vector3(15, 30, 35) * Time.deltaTime);
		}
		// Fire projectile
		else if (!lbPressed && previousLBDown)
		{
			print ("LB released");
			cubeMagnet.rigidbody.velocity += 1 * player.transform.forward;
		}
		
		previousLBDown = lbPressed;

	}

}

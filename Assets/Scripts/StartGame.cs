using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {


	// Update is called once per frame
	void Update () 
	{
		bool startPressed = OVRGamepadController.GPC_GetButton(OVRGamepadController.Button.Start);

		if (startPressed)
		{
			Application.LoadLevel("SeansRoom");
		}
	}
}

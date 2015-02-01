using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameLogic : MonoBehaviour 
{
	public int startingPull;
	public int startingPush;

	public Text pullTextLeft;
	public Text pushTextLeft;

	public Text pullTextRight;
	public Text pushTextRight;

	private int pullBlocksLeft;
	private int pushBlocksLeft;
	// Use this for initialization
	void Start () 
	{
		Application.LoadLevel ("SeansRoom");

		pullBlocksLeft = startingPull;
		pushBlocksLeft = startingPush;

		pullTextRight.text = "" + startingPull;
		pullTextLeft.text = "" + startingPull;

		pushTextLeft.text = "" + startingPush;
		pushTextRight.text = "" + startingPush;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void placePushBlock()
	{
		pushBlocksLeft--;
		pushTextLeft.text = "" + pushBlocksLeft;
		pushTextRight.text = "" + pushBlocksLeft;
	}

	public void placePullBlock()
	{
		pullBlocksLeft--;
		pullTextRight.text = "" + pullBlocksLeft;
		pullTextLeft.text = "" + pullBlocksLeft;
	}

	public int getPushBlocksLeft()
	{
		return pushBlocksLeft;
	}

	public int getPullBlocksLeft()
	{
		return pullBlocksLeft;
	}
}


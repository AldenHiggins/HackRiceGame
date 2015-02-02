using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndGame : MonoBehaviour 
{
	public Text uiTextLeft;
	public Text uiTextRight;
	public string nextLevelToLoad;

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.name == "CubeBullet(Clone)")
		{
			print ("Game over bro");
			uiTextLeft.text = "YOU WIN!!!!!";
			uiTextRight.text = "YOU WIN!!!!";
			if (nextLevelToLoad != null)
			{
				Application.LoadLevel(nextLevelToLoad);
			}
			
		}
	}
}

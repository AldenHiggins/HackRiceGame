﻿using UnityEngine;
using System.Collections;

public class BoxShooter : MonoBehaviour {
	
	public Rigidbody projectile;
	public Transform shotPos;
	public float shotForce;
	public float moveSpeed;
	
	
	
	// Update is called once per frame
	void Update () {
		
		float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
		float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
		
		//transform.Translate(new Vector3(h,v,0));
		
		if (Input.GetButtonUp("Fire1"))
		{
			Rigidbody shot = Instantiate (projectile, shotPos.position, shotPos.rotation) as Rigidbody;
			shot.AddForce(shotPos.forward * shotForce);
		}
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportation : MonoBehaviour {

	public GameObject Portal;
	public GameObject Player;
	public GameObject Camera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "mainPlayer")
		{
			// Debug.Log ("Teleport triggered");
			Teleport();
		}
	}

	public void Teleport()

	{
		Player.transform.position = new Vector2 (Portal.transform.position.x, Portal.transform.position.y);
	}
}

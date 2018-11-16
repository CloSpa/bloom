using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMaze : MonoBehaviour {

	public Transform heroObj;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("z"))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -3);
			// heroObj.transform.eulerAngles = new Vector3 (0, 0, -90);
		}

		else

		if (Input.GetKey ("s"))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 3);
			// heroObj.transform.eulerAngles = new Vector3 (0, 0, 90);
		}

		else

		if (Input.GetKey ("q"))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (3, 0);
			// heroObj.transform.eulerAngles = new Vector3 (0, 0, 0);
		}

		else

		if (Input.GetKey ("d"))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-3, 0);
			// heroObj.transform.eulerAngles = new Vector3 (0, 0, 180);
		}

		else

		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
		}

	}	
}

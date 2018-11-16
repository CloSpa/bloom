using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainPlayer : MonoBehaviour {

	public int keys = 0;
	public Text countKeysText;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Key")
		{
			keys += 1;
			Destroy (other.gameObject);
		}

		countKeysText.text = keys.ToString();
	}

	void OnCollisionEnter2D(Collision2D other)
	{

		if (other.collider.tag == "Door" && keys > 0)
		{
			keys -= 1;
			Destroy(other.collider.gameObject);
		}

		countKeysText.text = keys.ToString();
	}
}

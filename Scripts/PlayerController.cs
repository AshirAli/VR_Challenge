using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;
	public GameObject Pick;

	private Rigidbody rb;
	private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}


	void OnTriggerEnter(Collider other) // Use this function in player controll to destroy coin
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			{
				other.gameObject.SetActive (false);
			}
			count = count + 1; //skip this 2 lines since there is seperate script for coin collection
			SetCountText ();
		}
		else
		{
			{
				other.gameObject.SetActive (false);
			}
		}

	}

	void  SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 8)
		{
			winText.text = "You Win!";
		}

	}
}

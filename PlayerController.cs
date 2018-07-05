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
	public Transform rBorder;
	public Transform lBorder;
	public Transform tBorder;
	public Transform bBorder;

	private Rigidbody rb;
	private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
		SpawnPick ();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	public void SpawnCoin()
	{
		int x = (int)Random.Range (lBorder.position.x, rBorder.position.x);
		int y = (int)Random.Range (bBorder.position.y, tBorder.position.y);
		Instantiate (Pick,new Vector2 (x,y),Quaternion.identity);
	}

	void OnTriggerEnter(Collider other) 
	{
		/*if (other.gameObject.CompareTag ( "Pick Up"))  // use this for simple coin collection
		{
			other.gameObject.SetActive (false);

			count = count + 1;
			SetCountText ();
		}*/
		if (other.name.StartsWith ("Pick")) {
			Destroy (other.gameObject);
			SpawnPick ();
		}
	}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 8)
		{
			winText.text = "You Win!";
		}

	}
}

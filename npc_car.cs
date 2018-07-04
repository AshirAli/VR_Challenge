using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_car : MonoBehaviour {


	public float speed = 1.1f;
	public AudioClip CarAudio;
	public GameObject CarEffect;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {

		print ("Trigger Enter");
		
		GetComponent<AudioSource> ().PlayOneShot (CarAudio);
		CarEffect.SetActive (true);


		transform.Translate (Vector3.forward * speed,Space.World);
	}
}

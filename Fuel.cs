using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour {

	void OnTriggerEnter(Collider col){

		Destroy (gameObject);
	}
}
//Just Destroying fuel on collision not respawning after some time.

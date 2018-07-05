using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour {

	void OnTriggerEnter(Collider col){

		Destroy (gameObject);
		Timer.timeRemaining += 5;

	}
}
//Just Destroying fuel on collision not respawning after some time.

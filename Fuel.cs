using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour {

	void OnTriggerEnter(Collider col){

		Destroy (gameObject);
	}



}

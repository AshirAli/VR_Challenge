using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	Text timerText;
	public static int timeRemaining=10;


	void Start () {

		timerText = GetComponent<Text> ();
		StartCoroutine (StartTimer ());

	}

	IEnumerator StartTimer () {
		Debug.Log ("Started");

		while (true) {
			timerText.text = "" + timeRemaining;
			yield return new WaitForSeconds (1);
			timeRemaining--;

			if (timeRemaining <= 0) {

				Debug.Log ("Timer Stopped.");
				StopCoroutine (StartTimer ());
				timeRemaining = 4;
				SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);

			}
		}
	}
}
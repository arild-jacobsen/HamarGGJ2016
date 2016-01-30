using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneTestController : MonoBehaviour {
	GameStateScript gameState;

	// Use this for initialization
	void Start () {
		gameState = GameObject.Find ("GameState").GetComponent<GameStateScript>();
		Debug.Log("Has clicked Fire1 " + gameState.fire1ClickedCount + " times.");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			gameState.fire1ClickedCount++;
		}
		if (Input.GetButtonDown ("Fire2")) {
			SceneManager.LoadScene (1);
		}
	}
}

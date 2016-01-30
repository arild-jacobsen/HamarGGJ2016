using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public abstract class GameStateEnabledBehaviour : MonoBehaviour {
	protected GameStateScript gameState;

	// Use this for initialization
	virtual public void Start () {
		gameState = GameObject.Find ("GameState").GetComponent<GameStateScript>();
	}
}
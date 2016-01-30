using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public abstract class SceneController : GameStateEnabledBehaviour {

	// Use this for initialization
	override public void Start () {
		base.Start ();
		Debug.Log ("Loaded " + SceneManager.GetActiveScene().name + ", click count is " + gameState.fire1ClickedCount);
	}

	// Update is called once per frame
	virtual public void Update () {
		if (Input.GetButtonDown ("Fire2")) {
			goToNextScene ();
		}
	}

	virtual protected void goToNextScene() {
		SceneManager.LoadScene (getNextSceneName());
	}

	abstract protected string getNextSceneName ();
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneEndController : SceneController {
	public Text text;

	override public void Start() {
		
	}

	override protected void goToNextScene() {
		GameObject.Destroy (gameState.gameObject);
		base.goToNextScene ();
	}

	override protected string getNextSceneName () {
		return "Scenes/Scene1";
	}
}

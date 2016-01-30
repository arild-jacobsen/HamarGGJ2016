using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scene2Controller : SceneController {
	override protected string getNextSceneName () {
		return "Scenes/Scene3";
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scene1Controller : SceneController {
	override protected string getNextSceneName () {
		return "Scenes/Scene2";
	}
}

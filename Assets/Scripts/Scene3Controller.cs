using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scene3Controller : SceneController {
	override protected string getNextSceneName () {
		return "Scenes/Scene4";
	}
}

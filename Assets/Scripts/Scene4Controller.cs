using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scene4Controller : SceneController {
	override protected string getNextSceneName () {
		return "Scenes/End";
	}

}

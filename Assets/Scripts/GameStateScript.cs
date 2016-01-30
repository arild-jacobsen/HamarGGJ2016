using UnityEngine;
using System.Collections;

public class GameStateScript : MonoBehaviour {
	public int fire1ClickedCount = 0;

	// Use this for initialization
	void Start () {
		Object.DontDestroyOnLoad (this);
	}
}

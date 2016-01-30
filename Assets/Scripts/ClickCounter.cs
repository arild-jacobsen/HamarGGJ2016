using UnityEngine;
using System.Collections;

public class ClickCounter : GameStateEnabledBehaviour {
	// Use this for initialization
	override public void Start () {
		base.Start ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			gameState.fire1ClickedCount++;
		}
	}
}

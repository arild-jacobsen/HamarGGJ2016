using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class background : MonoBehaviour {


	Image bakgroundcolor;

	static float happynes;

	static float newColor = 1;


	public Color A = Color.white;
	public Color B;

	// Use this for initialization
	void Start () {

		bakgroundcolor = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {

		newColor = GameMaster.LevelOfdepresion / 255;
		B = new Color(newColor, newColor, newColor, 1);
		newColor = GameMaster.LevelOfdepresion / 255;
		//print(newColor);
		bakgroundcolor.color = Color.Lerp(bakgroundcolor.color, B, Time.deltaTime * 0.5f);
	

	}
}

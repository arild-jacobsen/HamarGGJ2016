using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class interationObject : MonoBehaviour {

	//public GameObject [] Action;
	public string valg1 = "use it";
	public string valg2 = "Leave it";

	public int reward = 1;
	public string Event = "";

	bool itemErTrykt = false;
	bool answerdIsdone = false;
	bool answerdIsdone2 = false;

	//public Transform option1;
	//public Transform option2;

	public Transform me;

	public GameObject andreknapper1;
	public GameObject andreknapper2;
	


	Button bla;
	

	// Use this for initialization
	void Start ()
	{
		bla = me.GetComponent<Button>();

	}
	
	// Update is called once per frame
	void Update () {
		if (itemErTrykt)
		{
			bla.interactable = false;
			itemErTrykt = false;
			
		}
		if(answerdIsdone)
		{
			andreknapper1.SetActive(true);
			andreknapper2.SetActive(true);
			me.GetChild(0).gameObject.SetActive(false);
			me.GetChild(1).gameObject.SetActive(false);
			GameMaster.NumberOfChoise--;
			GameMaster.LevelOfdepresion =+ reward;
			GameMaster.eventSaver = Event;
			answerdIsdone = false;
			
		}
		if(answerdIsdone2)
		{
			andreknapper1.SetActive(true);
			andreknapper2.SetActive(true);
			me.GetChild(0).gameObject.SetActive(false);
			me.GetChild(1).gameObject.SetActive(false);
			bla.interactable = true;
			answerdIsdone2 = false;
		}


	}

	public void selectValg1()
	{
		answerdIsdone = true;
	}

	public void selectValg2()
	{
		answerdIsdone2 = true;
	}

	public void useditem()
	{
		/*
				Transform RightOption1 = Instantiate(option1, Vector3.zero, Quaternion.identity) as Transform;
				Transform RightOption2 = Instantiate(option2, Vector3.zero, Quaternion.identity) as Transform;

				RightOption1.SetParent(parentplass);
				RightOption2.SetParent(parentplass);

				RightOption1.transform.localPosition = Vector3.zero;
				RightOption2.transform.localPosition = Vector3.zero;
				RightOption1.transform.localScale = Vector3.one;
				RightOption2.transform.localScale = Vector3.one;


				RightOption1.transform.Translate(-30, 20, 0);
				RightOption2.transform.Translate(30, 20, 0);



				RightOption1.GetChild(0).GetComponent<Text>().text = valg1;
				RightOption2.GetChild(0).GetComponent<Text>().text = valg2;
		*/
		me.GetChild(0).gameObject.SetActive(true);
		me.GetChild(1).gameObject.SetActive(true);

		me.GetChild(0).GetChild(0).GetComponent<Text>().text = valg1;
		me.GetChild(1).GetChild(0).GetComponent<Text>().text = valg2;

		andreknapper1.SetActive(false);
		andreknapper2.SetActive(false);

		itemErTrykt = true;
		
	}


	
	}

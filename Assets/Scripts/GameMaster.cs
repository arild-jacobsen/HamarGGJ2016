using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{

	public int inspectorNumberOfChoise = 2;
	[HideInInspector]
	public static int NumberOfChoise;
	int thisLevel = 1;
	public static int LevelOfdepresion;

	public static string eventSaver; 

	int eventnumber1 = 0;
	int eventnumber2 = 0;
	int eventnumber3 = 0;

	int day = 0;

    public static GameMaster Instance;

    void Awake()
    {
        if(Instance)
                 DestroyImmediate(gameObject);
             else
             {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }


    // Use this for initialization
    void Start ()
	{
		NumberOfChoise = inspectorNumberOfChoise;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (NumberOfChoise == 0)
		{
			NumberOfChoise = inspectorNumberOfChoise;
			thisLevel++;
			if (thisLevel == 5)
			{
				day++;
				thisLevel = 0;
			}
			SceneManager.LoadScene(thisLevel);
			

		}
		
		if (Input.GetButton("Cancel"))
		{
            SceneManager.LoadScene(0);
        }

		if (eventSaver == "face")
		{
			eventnumber2++;
			eventSaver = "";
		}
		if (eventnumber2 == 2 && thisLevel == 2 && day == 2)
		{
			
		}
		
			
	}
}

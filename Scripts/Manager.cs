using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Manager : MonoBehaviour {


    public static int currentScore;
    public static int highScore;

    public static int currentLevel=0;
    public static int unLockedlevel;


    public static void CompleteLevel()
    {
        currentLevel += 1;
        SceneManager.LoadScene(currentLevel);
        

    }

	// Use this for initialization
	void Start () {



		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

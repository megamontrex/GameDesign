using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () 
        { 
        print("Loading lvl" + LvlName);

        SceneManager.LoadScene(LvlName);

    }
    public void Exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
	
}

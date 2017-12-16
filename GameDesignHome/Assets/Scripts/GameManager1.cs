using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{

    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;

    private LevelManager lvl;

    public GUISkin layout;

    GameObject myBall;

    // Use this for initialization
    void Start()
    {
        PlayerScore1 = 0;
        PlayerScore2 = 0;
        myBall = GameObject.Find("Ball");
        lvl = GameObject.FindObjectOfType<LevelManager>();
    }

    public static void Score (string wallID)
    {
        if (wallID == "RightWall")
        {
            PlayerScore1++;
        }
        else
        {
            PlayerScore2++;
        }
    }
    void OnGUI()
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + PlayerScore1);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + PlayerScore2);


        if (PlayerScore1 == 3)
        {
            lvl.LoadNextLevel();
            
        }
        else if (PlayerScore2 == 3)
        {
            lvl.LoadNextLevel();

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

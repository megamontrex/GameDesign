using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;
    private bool hasStarted = false;

    public GUISkin layout;

    GameObject myBall;

    // Use this for initialization
    void Start () {
        myBall = GameObject.FindGameObjectWithTag("Ball");
    }


    public static void Score(string wallID)
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
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER ONE WINS");
            myBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
        else if (PlayerScore2 == 3)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER TWO WINS");
            myBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}

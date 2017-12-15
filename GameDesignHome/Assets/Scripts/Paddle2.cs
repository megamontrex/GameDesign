using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : MonoBehaviour {

    private Ball myBall;

	// Use this for initialization
	void Start () {
        myBall = GameObject.FindObjectOfType<Ball>();
    }
	
	// Update is called once per frame
	void Update () {
        float mousePosInBlocks = (Input.mousePosition.y / Screen.height * 5f)-2.25f;


        Vector3 paddlePosition = new Vector3(this.transform.position.x, 0f);
        

        paddlePosition.y = mousePosInBlocks;


        this.transform.position = paddlePosition;
	}
}

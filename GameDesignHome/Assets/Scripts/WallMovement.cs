using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour {

    public Transform Wall;
    public float WallSpeed;
	// Use this for initialization
	void Start () {
        Wall = GameObject.Find("Ball").transform;
	}
	
	// Update is called once per frame
	void Update () {
        float move = WallSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Wall.position, move);
	}
}

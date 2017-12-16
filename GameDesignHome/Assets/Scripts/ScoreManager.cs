using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.name == "Ball")
        {
            string wallName = transform.name;
            GameManager1.Score(wallName);
            hitInfo.gameObject.SendMessage("Restart Game", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

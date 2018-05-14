using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [HideInInspector]
    public Rigidbody2D playerRig;
	// Use this for initialization
	void Start () {
        playerRig = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        
            playerRig.AddForce(Vector2.right*5f);
        
    }
}

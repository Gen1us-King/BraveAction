using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour {

    private GameObject Player;
    public float MaxMarginY_H = 22f;
    public float MaxMarginY_B = -23f;

    private void Awake()
    {
        
    }
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
       
    }
   
    private void FixedUpdate()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        if (Player)
        {
        
        float newY = Player.transform.position.y - 1.5f;
        newY = Mathf.Clamp(newY, MaxMarginY_B, MaxMarginY_H);//限制摄像机范围        
        transform.position = new Vector3(0, newY, transform.position.z);
        }
    }
}

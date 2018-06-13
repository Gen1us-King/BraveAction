using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow_H : MonoBehaviour {

    public float CheckX;
    public float Smooth;
    public float MixPositionX;
    public float MaxPositionX;
    GameObject Player;
    private float NewPositionX = -26;
    // Use this for initialization
    private void Awake()
    {
         Player = GameObject.FindGameObjectWithTag("Player");
    }
    void Start () {
        transform.position = new Vector3(-26, 0, -10);
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    private void FixedUpdate()
    {
        if (CheckMargin())
        {
            NewPositionX = Mathf.Lerp(transform.position.x, Player.transform.position.x, Smooth);
        }
        NewPositionX = Mathf.Clamp(NewPositionX, MixPositionX, MaxPositionX);
        transform.position = new Vector3(NewPositionX, transform.position.y, transform.position.z);
    }
    bool CheckMargin()
    {
        return Mathf.Abs(Player.transform.position.x - transform.position.x) > CheckX;
    }
}

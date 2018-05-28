using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind_sound : MonoBehaviour {

    AudioSource Wind_down;
    Rigidbody2D player_Rig;
    GameObject player;
    Transform parachute;
    private bool Isplay = false;
	// Use this for initialization
	void Start () {
        Wind_down = GetComponent<AudioSource>();
	}
	// Update is called once per frame
	void Update () {      
        player = GameObject.FindGameObjectWithTag("Player");
        if (player)
        {        
            player_Rig = player.GetComponent<Rigidbody2D>();
            if (player_Rig.velocity.y != 0f && !Isplay)
            {
                Wind_down.Play();
                Isplay = true;
            }
          
            else if(player_Rig.velocity.y == 0 && Isplay)
            {              
                Wind_down.Stop();
                parachute = player.transform.Find("parachute");
                Destroy(parachute.gameObject);                         
                GetComponent<wind_sound>().enabled = false;
            }
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane_events : MonoBehaviour {

    AudioSource plane_sound;
    public GameObject Player;
    public GameObject health;
    public  Vector3 Player_postion;
    public Transform Canvas_UI;
    private bool istime = false;
	// Use this for initialization
	void Start () {
        plane_sound = GetComponent<AudioSource>();
        //Canvas_Tranform = GameObject.FindObjectOfType<Canvas>().transform;
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    private void FixedUpdate()
    {
        if (istime)
        {
            plane_sound.volume = plane_sound.volume - 0.006f;
            if (plane_sound.volume == 0)
            {
                plane_sound.Stop();
            }
        }
    }
    void  PlayAudio()
    {
        plane_sound.Play();
    }
    void Instantiate_Player()
    {
       Instantiate(health, Canvas_UI.transform);
       Instantiate(Player, Player_postion,Quaternion.identity);
        //初始化人物和血条
       istime = true;
    }
}

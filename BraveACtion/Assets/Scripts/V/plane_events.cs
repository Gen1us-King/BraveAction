using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane_events : MonoBehaviour {

    AudioSource Plane_Sound;
    public GameObject Player;
    public GameObject Health;
    public  Vector3 Player_Postionoffset;
    public Transform Canvas_UI;
    private bool istime = false;
	// Use this for initialization
	void Start () {
        Plane_Sound = GetComponent<AudioSource>();
        //Canvas_Tranform = GameObject.FindObjectOfType<Canvas>().transform;
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    private void FixedUpdate()
    {
        if (istime)
        {
            Plane_Sound.volume = Plane_Sound.volume - 0.006f;
            if (Plane_Sound.volume == 0)
            {
                Plane_Sound.Stop();
            }
        }
    }
    void  PlayAudio()
    {
        Plane_Sound.Play();
    }
    void Instantiate_Player()
    {
       Instantiate(Health, Canvas_UI.transform);
       Instantiate(Player, transform.position - Player_Postionoffset, Quaternion.identity);
        //初始化人物和血条
       istime = true;
    }
}

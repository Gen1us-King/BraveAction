using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health_control : MonoBehaviour {

    public Slider Health_Slider;
    private int HP;
	// Use this for initialization
	void Start () {
        HP = 100;
        Health_Slider.value = Health_Slider.maxValue = HP;//初始化血条；
    }
	
	// Update is called once per frame
	void Update () {

    }
    public void OnHit(int damage)
    {
        if (HP > 0)
        {
            HP -= damage;
            Health_Slider.value = HP;
         
        }
        else
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            Destroy(transform.gameObject);
        }
        
    }
}

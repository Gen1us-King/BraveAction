using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckScene : MonoBehaviour {

    private GameObject player;
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
        player = GameObject.FindGameObjectWithTag("Player");
        if (player)
        {
            GameObject.DontDestroyOnLoad(player);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        SceneManager.LoadScene("horizontal", LoadSceneMode.Single);
    }
}

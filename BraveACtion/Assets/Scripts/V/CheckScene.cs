using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckScene : MonoBehaviour {
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

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = new Vector3(-37.8f, -4.3f, 0);
        SceneManager.LoadScene("horizontal", LoadSceneMode.Single);
    }
}

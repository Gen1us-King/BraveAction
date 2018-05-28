using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    [HideInInspector]
    public Rigidbody2D playerRig;
    public float MaxSpeed = 10f;
    public float Thrust = 50f;
    public float JumpForce = 20f;
    Animator animator_down;
    Transform Ground;

    private bool Jump;
    private bool groundCheck;
    private health_control Health_Control;
	// Use this for initialization
	void Start () {
        playerRig = GetComponent<Rigidbody2D>();
        animator_down = GetComponent<Animator>();
        Ground = transform.Find("ground");
        Health_Control = GameObject.Find("health(Clone)").GetComponent<health_control>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Ground) {
            groundCheck = Physics2D.Linecast
                (transform.position, Ground.position, 1 << LayerMask.NameToLayer("ground"));
        }
        
        if (Input.GetButtonDown("Jump") && groundCheck) 
        {
            Jump = true;
        }
    }
    private void FixedUpdate()
    {
        bool isLeft = false;
        bool  isRight = false;
      
        float finput = Input.GetAxis("Horizontal");

        if (finput > 0) { isRight = true; }
        animator_down.SetBool("isRight", isRight);
        if (finput < 0) { isLeft = true; }
        animator_down.SetBool("isLeft", isLeft);
        //降落时左右移动动画；

        if (finput * playerRig.velocity.x < MaxSpeed)
        {
            playerRig.AddForce(finput * Vector2.right * Thrust, ForceMode2D.Force);
        }
        else if (Mathf.Abs(playerRig.velocity.x) > MaxSpeed) 
        {
            playerRig.velocity =
                new Vector2(Mathf.Sign(playerRig.velocity.x) * MaxSpeed, playerRig.velocity.y);

        }
        if (Jump)
        { 
            playerRig.AddForce(Vector2.up * JumpForce);
            Jump = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void OnParticleCollision(GameObject other)
    {
      if (other.tag == "arrow")
        {
            Health_Control.OnHit(40);
        }
         
    }
}

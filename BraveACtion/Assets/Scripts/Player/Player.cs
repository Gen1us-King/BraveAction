using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    [HideInInspector]
    public Rigidbody2D PlayerRig;
    public float MaxSpeed = 10f;
    public float Thrust = 50f;
    public float JumpForce = 20f;

    Animator Animator_Down;
    Transform Ground;

    private bool isV;//是否在竖直方向移动
    private bool Jump;
    private bool GroundCheck;
    private health_control Health_Control;
    // Use this for initialization
    private void Awake()
    {
        isV = true;
        Health_Control = GameObject.Find("health(Clone)").GetComponent<health_control>();
       //
        Ground = transform.Find("ground");
        PlayerRig = GetComponent<Rigidbody2D>();
        Animator_Down = GetComponent<Animator>();       
    }
    void Start () {
        DontDestroyOnLoad(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
            GroundCheck = Physics2D.Linecast
                (transform.position, Ground.position, 1 << LayerMask.NameToLayer("ground"));
        
        if (Input.GetButtonDown("Jump") && GroundCheck) 
        {
            Jump = true;
        }       
    }
    private void FixedUpdate()
    {
        if (isV)
        {
            PlayerMove_V();
        }
        else
        {
            PlayerMove_H();
        }
        if (Jump)
        { 
            PlayerRig.AddForce(Vector2.up * JumpForce);
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
            Health_Control.OnHit(20);
        }
         
    }
    void PlayerMove_V()//竖直方向移动控制函数 
    {
        bool isLeft = false;
        bool isRight = false;

        float finput = Input.GetAxis("Horizontal");

        if (finput > 0) { isRight = true; }
        Animator_Down.SetBool("isRight", isRight);
        if (finput < 0) { isLeft = true; }
        Animator_Down.SetBool("isLeft", isLeft);
        //降落时左右移动动画；

        if (finput * PlayerRig.velocity.x < MaxSpeed)
        {
            PlayerRig.AddForce(finput * Vector2.right * Thrust, ForceMode2D.Force);
        }
        else if (Mathf.Abs(PlayerRig.velocity.x) > MaxSpeed)
        {
            PlayerRig.velocity =
                new Vector2(Mathf.Sign(PlayerRig.velocity.x) * 
                MaxSpeed, PlayerRig.velocity.y);
        }

        if (GroundCheck) isV = false;
    }
    void PlayerMove_H()//水平方向移动控制函数
    {
        float finput = Input.GetAxis("Horizontal");
        if (GroundCheck)
        {
            if (finput * PlayerRig.velocity.x < MaxSpeed)
            {
                PlayerRig.AddForce(finput * Vector2.right * Thrust, ForceMode2D.Force);
            }
            else if (Mathf.Abs(PlayerRig.velocity.x) > MaxSpeed)
            {
                PlayerRig.velocity =
                    new Vector2(Mathf.Sign(PlayerRig.velocity.x) * MaxSpeed, PlayerRig.velocity.y);

            }
        }
    }
    void SwitchItem()
    {

    }
}

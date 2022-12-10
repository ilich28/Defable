using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Move : MonoBehaviour
{
    static public int moveRight = 1;
    public int Health = 100;
    public float Speed = 10.0f;
    public float jumpForce  = 7f; 

    private bool isGrounded;
    private bool isStopped;
  
    static public bool isAttacking;
    public Transform feetPos;
    public float cheackRadius;
    public LayerMask whatIsGround;


    public Rigidbody2D PlayerRigibody;
     public Rigidbody2D rb;
    public Vector2 moveVector;
    public Animator CharAnimator;
    public SpriteRenderer Sprite;
    private Transform player;


    public int damage=25;
    public string collisionTag;


    private void Awake() {
        PlayerRigibody = GetComponentInChildren<Rigidbody2D>();
        CharAnimator = GetComponentInChildren<Animator>();
        Sprite = GetComponentInChildren<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }



 void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }
//  void FixedUpdate()
//     {
//         MovementLogic();
//         //JumpLogic();
//     }
    //  private void MovementLogic()
    // {
    //     float moveHorizontal = Input.GetAxis("Horizontal");

    //     Vector3 movement = new Vector3(moveHorizontal*Speed,GetComponent<Rigidbody2D>().velocity.y);

        
    // }
    //  void OnCollisionEnter(Collision collision)
    // {
    //     IsGroundedUpate(collision, true);
    // }

    // void OnCollisionExit(Collision collision)
    // {
    //     IsGroundedUpate(collision, false);
    // }

    // private void IsGroundedUpate(Collision collision, bool value)
    // {
    //     if (collision.gameObject.tag == ("land"))
    //     {
    //         isGrounded = value;
    //     }
    // }
    void Move() {
        if (Input.GetButton("Horizontal")){
            // Vector3 tempvector = Vector3.right * Input.GetAxis("Horizontal");
            // transform.position = Vector3.MoveTowards(transform.position, transform.position + tempvector, Speed * Time.deltaTime);
            moveVector.x = Input.GetAxis("Horizontal");
            rb.velocity =new Vector2(moveVector.x*Speed,rb.velocity.y);
            if (moveVector.x < 0)
            {
                moveRight = -1;
                transform.localScale = new Vector2(-1,1);

            }
            else
            {
                moveRight = 1;
                transform.localScale = new Vector2(1,1); 
            }

        }
    }

    void Attacks(){
        if (Input.GetKeyDown(KeyCode.E)){
            isAttacking = true;
        }
        else{
            isAttacking = false;
        }
    }
    
    

    void Jump(){
        isGrounded = Physics2D.OverlapCircle(feetPos.position,  cheackRadius, whatIsGround);
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)){
            if (isGrounded == true){
                PlayerRigibody.velocity = Vector2.up * jumpForce;
            }
        }

    }

    void Update()
    {
        Jump();
        Move();
        Attacks();
        if (isAttacking){
            CharAnimator.SetInteger("State", 3);
        }
        else if (!isGrounded){
            CharAnimator.SetInteger("State", 2);
        }
        else if (Input.GetButton("Horizontal"))
        { 
            CharAnimator.SetInteger("State", 1);
        }
        else {
            CharAnimator.SetInteger("State", 0);
        }
        
    }
}

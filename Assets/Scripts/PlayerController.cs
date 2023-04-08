using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float MoveDirection;
    float nextAttackTime = 0;
    public float playerSpeed;
    public float JumpPower;
    public float GroundCheckRadius;
    public float AttackRate;
    public float AttackRange;
    public float PlayerDamage;
    

    bool isgrounded;

    Rigidbody2D playerRb;

    SpriteRenderer playerSR;

    public Transform AttackTransform;

    Animator playerAnim;

    public LayerMask groundLayer;
    public LayerMask enemyLayer;

    public GameObject GroundCheck;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerSR = GetComponent<SpriteRenderer>();
        playerAnim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Movement();
        
    }
    void Update()
    {
        
        CheckRotation();
        Jump();
        DontAllowInfinityJump();
        CheckAnimations();
        Attack();

        //Debug.Log(isgrounded);

    }

    void Movement()
    {
        MoveDirection = Input.GetAxisRaw("Horizontal");
        playerRb.velocity = new Vector2(playerSpeed * MoveDirection, playerRb.velocity.y);
        playerAnim.SetFloat("Run",Mathf.Abs(MoveDirection*playerSpeed));
        
    }
    void CheckAnimations()
    {
        playerAnim.SetBool("isGrounded", isgrounded);
    }

    void CheckRotation()
    {
        if (MoveDirection < 0)
        {
            playerSR.flipX = enabled;
        }
        else if (MoveDirection > 0 )
        {
            playerSR.flipX = !enabled;
        }
    }
    void Jump()
    {
        if (isgrounded)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {

                playerRb.velocity = new Vector2(playerRb.velocity.x, JumpPower);
            }
        }
       
    }
   public void Attack()
    {
        if (Time.time > nextAttackTime)
        {
            
            if ((Input.GetKeyDown(KeyCode.Mouse0)))
            {


                if (MoveDirection == 0)
                {
                    playerAnim.SetTrigger("Attack1");
                }

                else if (MoveDirection != 0)
                {
                    playerAnim.SetTrigger("Attack2");
                }





                if (isgrounded)
                {
                    Collider2D[] hitenemies = Physics2D.OverlapCircleAll(AttackTransform.position, AttackRange, enemyLayer);
                    foreach (Collider2D hits in hitenemies)
                    {
                        hits.GetComponent<EnemyStats>().TakeDamage(PlayerDamage);
                    }
                }
                nextAttackTime = Time.time + 1f / AttackRate;
            }
            
        }
       

    }
    void DontAllowInfinityJump()
    {
        isgrounded = Physics2D.OverlapCircle(GroundCheck.transform.position, GroundCheckRadius, groundLayer);
    }

    
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(GroundCheck.transform.position, GroundCheckRadius);
        Gizmos.DrawWireSphere(AttackTransform.position, AttackRange);
    }
}

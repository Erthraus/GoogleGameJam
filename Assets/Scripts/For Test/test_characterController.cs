using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class test_characterController : MonoBehaviour
{
    /**This code is a horizontal character controller. If user wants to go right and presses "D", the character starts going to right
    with 4.00 speed and to the right direction (not flipped) running animation, if user wants to go left and presses "A", the character starts going to left
    with 4.00 speed and to the left (flipped) direction running animation. Also, if user doesn't press any button, the character stays at it's position with idle animation.  **/


    public float speed = 0.0f;  //First Speed
    public bool run = false;    //Run check for Animator
    private Rigidbody2D r2d;
    private SpriteRenderer _spriteRenderer;


    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();   //caching _spriteRenderer
        r2d = GetComponent<Rigidbody2D>();  //caching r2d
        
    }

 
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            speed = 7.0f;
            _spriteRenderer.flipX = false;
            run = true;
        
        }
        else if (Input.GetKey(KeyCode.A))
        {
            speed = -7.0f;
            _spriteRenderer.flipX = true;
            run = true;

        }

        else
        {
            speed = 0.0f;
            run = false;

        }



        r2d.velocity = new Vector2(speed, 0f);


    }
}

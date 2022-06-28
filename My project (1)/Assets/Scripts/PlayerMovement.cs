using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    public float runSpeed = 40f;

    public float horizontalMove = 0f;
    private bool jump = false;

    private Animator animator;

    private Rigidbody rb;
    public bool moving = false;

    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(horizontalMove > 0f || horizontalMove < 0f)
        {
            animator.SetInteger("AnimState", 1);
            moving = true;
        }
        else
        {
            animator.SetInteger("AnimState", 2);
            moving = false;
        }

        if (Input.GetButtonDown("Jump") && controller.m_Grounded)
        {
            animator.SetBool("Jump", true);
            jump = true;
        }
        


    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}

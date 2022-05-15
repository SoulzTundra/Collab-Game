using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustAnimations : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(rb.velocity.x > 0 || rb.velocity.x < 0)
        {
            animator.SetBool("running", true);
        }
        else
        {
            animator.SetBool("running", false);
        }
    }
}

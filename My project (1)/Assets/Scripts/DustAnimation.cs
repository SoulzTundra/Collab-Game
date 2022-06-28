using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustAnimation : MonoBehaviour
{
    private Animator animator;
    public PlayerMovement playerMovement;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (playerMovement.moving == true)
        {
            animator.SetBool("running", true);
        }
        else
        {
            animator.SetBool("running", false);
        }
    }
}

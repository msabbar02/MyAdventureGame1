using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public Animator animator;
    public float jumpForce = 2f;

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody2D>().velocity = (Vector2.up  * jumpForce);
            animator.Play("JumpTrampoline");
        }
    } 
}

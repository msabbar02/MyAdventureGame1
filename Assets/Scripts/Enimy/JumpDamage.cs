using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpDamage : MonoBehaviour
{
   public Collider2D Collider2D;
   public SpriteRenderer spriteRenderer;
   public Animator animator;
   public GameObject DestroyParticle;
   public float jumpForce = 2.5f;
   public int lifes = 3;


   public void OnCollisionEnter2D(Collision2D other)
   {
      if (other.transform.CompareTag("Player"))
      {
         other.gameObject.GetComponent<Rigidbody2D>().velocity = (Vector2.up * jumpForce);
         LosseLifeAndHit();
         CheckLife();
      }
   }

   public void LosseLifeAndHit()
   {
      lifes--;
      animator.Play("Hit");
   }
   
   public void CheckLife()
   {
      if (lifes == 0)
      {
         DestroyParticle.SetActive(true);
         spriteRenderer.enabled = false;
         Invoke("EnemyDie" ,0.2f);
      }
   }

   public void EnemyDie()
   {
      Destroy(gameObject);
   }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeAttack : MonoBehaviour
{
    
    
    public Animator animator;
    public float distanceRaycast = 0.8f;
    private float cooldownAttack = 1.5f;
    private float actualColldownAttack;
    public GameObject beeBullet;
    void Start()
    {
        actualColldownAttack = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
        actualColldownAttack  -= Time.deltaTime;
        Debug.DrawRay(transform.position, Vector2.down, Color.red,distanceRaycast);
        
        
    }

    private void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distanceRaycast);
        if (hit.collider != null)
        {
            if (hit.collider.CompareTag("Player"))
            {
                if (actualColldownAttack < 0)
                {
                    Invoke("lanchBullet",0.5f);
                    animator.Play("Attack");
                    actualColldownAttack = cooldownAttack;
                }
            }
        }
    }

    void lanchBullet()
    {
        GameObject newBullet;
        newBullet = Instantiate(beeBullet, transform.position, transform.rotation);
    }
}

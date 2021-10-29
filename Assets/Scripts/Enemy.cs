using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float walkSpeed;

    [HideInInspector]
    public bool mustPatrol;
    private bool mustTurn;

    public Animator anim = null;
    public Rigidbody2D rb2d;
    public Transform groundCheckPos;
    public LayerMask groundLayer;
    public Collider2D bodyCollider;

    // Start is called before the first frame update
    void Start()
    {
        mustPatrol = true;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(mustPatrol)
        {
            Patrol();
        }
    }

    private void FixedUpdate()
    {
        if(mustPatrol)
        {
            mustTurn = !Physics2D.OverlapCircle(groundCheckPos.position, 0.1f, groundLayer);
        }
    }

    void Patrol()
    {
        anim.SetTrigger("Enemy_Walk");

        //if(mustTurn || bodyCollider.IsTouchingLayers(groundLayer))
        //{
        //    Flip();
        //}
        rb2d.velocity = new Vector2(walkSpeed * Time.fixedDeltaTime, rb2d.velocity.y);
    }

    void Flip()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        walkSpeed *= -1;
        mustPatrol = true;
    }

    // Animation
    void enemyIdle()
    {
        anim.SetTrigger("Enemy_Idle");
    }
    void enemyWalk()
    {
        anim.SetTrigger("Enemy_Walk");
    }
    void enemyAttack()
    {
        anim.SetTrigger("Enemy_Attack");
    }
    void enemyCast()
    {
        anim.SetTrigger("Enemy_Cast");
    }

}

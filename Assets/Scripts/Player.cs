using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 3.0f;
    private Rigidbody2D rb2d;
    private Animator anim = null;
    private bool attackFlg = false;
    private bool keyFlg = false;

   

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalKey = Input.GetAxisRaw("Horizontal");

        //ˆÚ“®(©¨orAD)
        if (horizontalKey > 0 && attackFlg == false)
        {
            rb2d.velocity = new Vector2(playerSpeed, rb2d.velocity.y);
            anim.SetBool("Run", true);
            transform.localScale = new Vector3(5, 5, 1);
        }
        else if (horizontalKey < 0 && attackFlg == false)
        {
            rb2d.velocity = new Vector2(-playerSpeed, rb2d.velocity.y);
            anim.SetBool("Run", true);
            transform.localScale = new Vector3(-5, 5, 1);
        }
        else
        {
            rb2d.velocity = Vector2.zero;
            anim.SetBool("Run", false);
        }

        //UŒ‚(ZƒL[)
        if (Input.GetKeyDown(KeyCode.Z) && keyFlg == false)
        {
            Attack();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Attack()
    {
        anim.SetTrigger("AttackTrg");     
        keyFlg = true;
    }

    void AttackStart()
    {
        attackFlg = true;

    }

    void AttackEnd()
    {
        attackFlg = false;
        keyFlg = false;
    }

    //–¢ŽÀ‘•
    void Jump()
    {
        //Debug.Log("”ò‚Ñ‚Ü‚µ‚½");
    }
}
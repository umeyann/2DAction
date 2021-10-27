using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator anim = null;
    private Rigidbody2D rb2d;

    private int move_type = 0;
    private Vector3 forward; 


    // 敵のフラグ
    private bool enemyIdle = true;
    private bool enemyWalk = false;
    private bool enemyAttack = false;
    private bool enemySpell = false;




    // デバック用フラグ
    private bool keyFlg = false;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Enemy_Idle)
        //{
        //    move_type = Random.Range(0, 4);
        //}
        //else if (Enemy_Walk)
        //{
        //    true;
        //}
        if (Input.GetKeyDown(KeyCode.P))
        {
            Enemy_Walk();
        }


    }


    // 敵の歩き
    void Enemy_Walk()
    {
        anim.SetTrigger("Enemy_Walk");
    }

    // 敵の通常攻撃
    void Enemy_Attack()
    {
        anim.SetTrigger("Enemy_Attack");
    }

    // 敵の魔法攻撃
    void Enemy_Cast()
    {
        anim.SetTrigger("Enemy_Cast");

    }


}
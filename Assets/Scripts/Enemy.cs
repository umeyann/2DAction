using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator anim = null;
    private Rigidbody2D rb2d;

    // 敵のフラグ
    private bool Enemy_walkFlg = false;
    private bool Enemy_attackFlg = false;
    private bool Enemy_spellFlg = false;

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
        if (Input.GetKeyDown(KeyCode.P) && keyFlg == false)
        {
            Enemy_Walk();
        }
    }


    // 敵の歩き
    void Enemy_Walk()
    {
        anim.SetTrigger("Enemy_Walk");
        keyFlg = true;
    }

    // 敵の通常攻撃
    void Enemy_Attack()
    {
        anim.SetTrigger("Enemy_Attack");
        keyFlg = true;
    }

    // 敵の魔法攻撃
    void Enemy_Spell()
    {
        anim.SetTrigger("Enemy_Spell");
        keyFlg = true;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator anim = null;
    private Rigidbody2D rb2d;

    private int move_type = 0;
    private Vector3 forward; 


    // �G�̃t���O
    private bool Enemy_Idle = true;
    private bool Enemy_Walk = false;
    private bool Enemy_Attack = false;
    private bool Enemy_Spell = false;




    // �f�o�b�N�p�t���O
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
        if(Enemy_Idle)
        {
            move_type = Random.Range(0, 4);
        }
        else if (Enemy_Walk)
        {
            true;
        }

    }


    // �G�̕���
    void Enemy_Walk()
    {
        anim.SetTrigger("Enemy_Walk");
    }

    // �G�̒ʏ�U��
    void Enemy_Attack()
    {
        anim.SetTrigger("Enemy_Attack");
    }

    // �G�̖��@�U��
    void Enemy_Cast()
    {
        anim.SetTrigger("Enemy_Cast");

    }


}
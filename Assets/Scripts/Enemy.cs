using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator anim = null;
    private bool Enemy_walkFlg = false;
    private bool keyFlg = false;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            anim.SetTrigger("Enemy_Walk");
        }
        //if (Input.GetKeyDown(KeyCode.P) && keyFlg == false)
        //{
        //    Enemy_Walk();
        //}
    }


    //void Enemy_Walk()
    //{
    //    anim.SetTrigger("Walk");
    //    keyFlg = true;
    //}

}

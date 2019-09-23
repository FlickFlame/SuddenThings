using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFollow : MonoBehaviour
{
    Rigidbody2D rb;
    public Animator anim;    
    public GameObject Enemy;

    void Start()
    {
         rb = Enemy.GetComponent<Rigidbody2D>();
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("Player") || other.gameObject.tag == "Bullet") 
        {
            Enemy.GetComponent<EnemyFollow>().enabled = true;
            anim.SetBool("Move", true);
        }
    }
/*
    void OnTriggerStay2D(Collider2D col)
    {
        Enemy.GetComponent<EnemyFollow>().follow = true;
        anim.SetBool("Move", true);

    }
*/
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == ("Player")) 
        {
            Enemy.GetComponent<EnemyFollow>().enabled = false;
            anim.SetBool("Move", false);
            rb.velocity = new Vector2(0f,0f);
        }

        else if (other.gameObject.tag == "Bullet")
        {
            Enemy.GetComponent<EnemyFollow>().enabled = true;
            anim.SetBool("Move", true);
        }
    }
}

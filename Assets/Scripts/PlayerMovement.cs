using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GameObject cam;
    
    public FixedJoystick joystick;

    private Animator anim;

    public GameObject Sword;

    Animator swordanim;

    private SpriteRenderer spren;

    private SpriteRenderer swordspren;

    public float Speed = 2f;

    private Rigidbody2D rb;

    private float Move;

    private float Move1;

    void Start ()
    {

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        swordanim = Sword.GetComponent<Animator>();
        spren = GetComponent<SpriteRenderer>();
        swordspren = Sword.GetComponent<SpriteRenderer>();

    }

    void Update()
    {
       //float Move = Input.GetAxis("Horizontal");
       //float Move1 = Input.GetAxis("Vertical"); 

        Move = joystick.Horizontal;
        Move1 = joystick.Vertical;

       rb.velocity = new Vector2 (Speed * Move, Speed * Move1);

       if(anim.GetBool("Move") == true)
            swordanim.SetBool("PlayerMove", true);

        if(anim.GetBool("Move") == false)
            swordanim.SetBool("PlayerMove", false);

       if (Input.GetButtonDown("Fire1"))
       {
            swordanim.Play("Hit");
       } 

        if (Move != 0f || Move1 != 0f)
       {
            anim.SetBool("Move", true);
       }
       
        else
        {
            anim.SetBool("Move", false);
        }
        if(Move > 0f)
        {
            spren.flipX = false;
            swordspren.flipX = false;
        }
        if(Move < 0f)
        {
            spren.flipX = true;
            swordspren.flipX = true;
        }

    }

}

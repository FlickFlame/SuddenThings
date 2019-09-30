using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GameObject cam;
    
    public FixedJoystick joystick;

    private Animator anim;

    public GameObject Sword;

    private SpriteRenderer spren;

    public float Speed = 2f;

    private Rigidbody2D rb;

    private float Move;

    private float Move1;

    void Start ()
    {

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spren = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
       //float Move = Input.GetAxis("Horizontal");
       //float Move1 = Input.GetAxis("Vertical"); 

        Move = joystick.Horizontal;
        Move1 = joystick.Vertical;

       rb.velocity = new Vector2 (Speed * Move, Speed * Move1);

       if (Input.GetButtonDown("Fire1"))
       {
//            swordanim.Play("Hit");
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
        }
        if(Move < 0f)
        {
            spren.flipX = true;
        }

    }

    public Vector2 Aponta() {
        Move = joystick.Horizontal;
        Move1 = joystick.Vertical;

        Vector2 vet = new Vector2 (Move, Move1);
        return vet.normalized;
    }

}

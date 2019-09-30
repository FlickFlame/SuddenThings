using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{


    public GameObject projectile;
    private float fireSpellStart = 0f;
    private float fireSpellCooldown = 0.5f;
    public PlayerMovement playerMovement;
    public Shooting shooting;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

            DoShoot();
            
         }
    }

    public void DoShoot() {
        Vector2 aponta = playerMovement.Aponta();
        Vector3 destino = new Vector3(transform.position.x + aponta.x, transform.position.y + aponta.y, 0f);
        Vector2 direction = destino - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = rotation;

        if (Time.time > fireSpellStart + fireSpellCooldown)
        {
            fireSpellStart = Time.time;
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }

    public void DoShootButton() {
        DoShoot();
        shooting.UpdateMana();
    }
}

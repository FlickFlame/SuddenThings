using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{


    public GameObject projectile;
    public Transform shotPoint;
    public ParticleSystem projectileParticles;
    private float fireSpellStart = 0f;
    private float fireSpellCooldown = 0.5f;

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = rotation;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time > fireSpellStart + fireSpellCooldown)
            {
                fireSpellStart = Time.time;
                Instantiate(projectile, shotPoint.position, transform.rotation);
            }
            
         }
    }
}
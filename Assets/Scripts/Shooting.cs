using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    private float timer = 0.0f;
    public GameObject KnifePrefab;
    private float fireSpellStart = 0f;
    private float fireSpellCooldown = 0.5f;
    private SpriteRenderer sprenmanabar;
    public GameObject ManaBar;
    public GameObject Shoot;
    public Sprite ManaSixBars;
    public Sprite ManaFourBars;
    public Sprite ManaTwoBars;
    public Sprite ManaNoBar;

    private int ManaIntCount = 6;

    void Start()
    {
         sprenmanabar = ManaBar.GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        if(ManaIntCount == 0)
            {
                sprenmanabar.sprite = ManaNoBar;
                Shoot.GetComponent<Shoot>().enabled = false;
            }

        if(ManaIntCount != 0)
            {
                Shoot.GetComponent<Shoot>().enabled = true;
            }

        if (Input.GetKeyDown(KeyCode.Space) && ManaIntCount >= 0f && ManaIntCount <= 6f)
        {

            Shoot.GetComponent<Shoot>().enabled = true;  

            if (Time.time > fireSpellStart + fireSpellCooldown)
            {
                fireSpellStart = Time.time;   

                if(ManaIntCount != 0)
                {
                    ManaIntCount = ManaIntCount - 2;
                }
            }

        }

            if(ManaIntCount == 2)
            {
                sprenmanabar.sprite = ManaTwoBars;
            }

            if(ManaIntCount == 4)
            {
                sprenmanabar.sprite = ManaFourBars;
            }

            if(ManaIntCount == 6)
            {
                 sprenmanabar.sprite = ManaSixBars;
            }

            if(ManaIntCount != 0)
            {
                Shoot.GetComponent<Shoot>().enabled = true;
            }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "ManaPotion")
        {
            if(ManaIntCount >=0 && ManaIntCount < 6)
            {
                ManaIntCount = ManaIntCount + 2;
                Destroy(col.gameObject);
            }
        }
    }

}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private int PHealth = 8;
    private SpriteRenderer sprenbar;
    public GameObject LifeBar;
    public Sprite LifeFourBars;
    public Sprite LifeThreeBars;
    public Sprite LifeTwoBars;
    public Sprite LifeOneBar;
    public Sprite LifeNoBar;

    void Start()
    {
        sprenbar = LifeBar.GetComponent<SpriteRenderer>();
    }
    void Update()
    {

        if(PHealth < 1)
        {
            sprenbar.sprite = LifeNoBar;
            Destroy(gameObject);
            SceneManager.LoadScene("TimeLine");
        }

        if(PHealth == 8)
        sprenbar.sprite = LifeFourBars;

        if(PHealth == 6)
        sprenbar.sprite = LifeThreeBars;

        if(PHealth == 4)
        sprenbar.sprite = LifeTwoBars;

        if(PHealth == 2)
        sprenbar.sprite = LifeOneBar;
        
    }
    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag == "Enemy")
        {
            PHealth = PHealth - 2;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "LifePotion")
        {
            if(PHealth >=0 && PHealth < 8)
            {
                PHealth = PHealth + 2;
                Destroy(col.gameObject);
            }
        }
    }

}
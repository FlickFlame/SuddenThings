using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordHit : MonoBehaviour
{    
    private int maxHealth = 8; 
    public int MiHealth = 2;

    [SerializeField]
    private SpriteRenderer sprenbar;
    private GameObject Bar;
    private GameObject Enemy;
    public Sprite FourBars;
    public Sprite ThreeBars;
    public Sprite TwoBars;
    public Sprite OneBar;
    public Sprite NoBar;

    void Start()
    {
        //Enemy = GameObject.FindWithTag("Player");
        //Bar = Enemy.gameObject.transform.GetChild(0).GetChild(0).gameObject;
        //sprenbar = Bar.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
    /*
        if(Input.GetMouseButtonDown(0)){
            Collider2D[] colliders = new Collider2D[3];
            transform.Find("SwordArea").gameObject.GetComponent<Collider2D>().OverlapCollider(new ContactFilter2D(), colliders);
                for (int i = 0; i < colliders.Length; i++){
                    if(colliders[i] != null && colliders[i].gameObject.CompareTag("Enemy")){
                        maxHealth = maxHealth - MiHealth;
                        if( maxHealth < 1){
                             Destroy(colliders[i].gameObject);
                        }

                        if(maxHealth == 8)
                            sprenbar.sprite = FourBars;

                        if(maxHealth == 6)
                            sprenbar.sprite = ThreeBars;

                        if(maxHealth == 4)
                            sprenbar.sprite = TwoBars;

                        if(maxHealth == 2)
                            sprenbar.sprite = OneBar;


                    }
                }
        }
    */
    }
}

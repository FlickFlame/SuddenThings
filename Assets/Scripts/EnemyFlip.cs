using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlip : MonoBehaviour
{

    GameObject Player;
    public GameObject Enemy;
    private SpriteRenderer spren;
    private float YPositionEnemy, YPositionPlayer;

    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        spren = Enemy.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Player != null) {
            Vector2 PosPlayer = new Vector2();
            PosPlayer = Player.transform.position;
            Vector2 PosEnemy = new Vector2();
            PosEnemy = Enemy.transform.position;

            if(PosPlayer.x < PosEnemy.x)
            {
                spren.flipX = true;
            }

            if(PosPlayer.x > PosEnemy.x)
            {
                spren.flipX = false;
            }
        }
    }
}
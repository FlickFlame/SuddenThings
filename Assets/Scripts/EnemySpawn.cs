using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject Enemy;
    float RandomX;
    float RandomY;
    Vector2 SpawnArea;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemy",0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemy()
    {
        for(int i=0;i<35;i++)
        {
        RandomX = Random.Range(27.64f,53.5f);
        RandomY = Random.Range(12.97f,-19.22f);
        SpawnArea = new Vector2 (RandomX,RandomY);
        Instantiate(Enemy,SpawnArea,Quaternion.identity);
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyFollow : MonoBehaviour
{

    public float speed = 3f;
    GameObject player;
    public GameObject EnemyEmpty;
    public SpriteRenderer spren;
    private SpriteRenderer sprenbar;
    Rigidbody2D rb;
    private int maxHealth = 8; 
    public int MiHealth = 2;
    public bool follow = true;
    public GameObject Bar;
    public Sprite FourBars;
    public Sprite ThreeBars;
    public Sprite TwoBars;
    public Sprite OneBar;
    public Sprite NoBar;
    public GameObject drop1;
    public GameObject drop2;
    private int random;
    public float repelForce = 10f;
    public float pushTime = 1f;
    private bool repelled = false;

    void Start()
    {
        spren = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        sprenbar = Bar.GetComponent<SpriteRenderer>();
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {

        random = Random.Range(0, 5);

        if(maxHealth < 1)
        {
        Destroy(gameObject);
        sprenbar.sprite = NoBar;
        }

        if(maxHealth == 8)
        sprenbar.sprite = FourBars;

        if(maxHealth == 6)
        sprenbar.sprite = ThreeBars;

        if(maxHealth == 4)
        sprenbar.sprite = TwoBars;

        if(maxHealth == 2)
        sprenbar.sprite = OneBar;

        if (repelled == false) {
            if (player != null && follow == true)
            {
                Vector3 direction = (player.transform.position - transform.position).normalized;
                rb.velocity = direction * speed;
            }

            else 
            {
                rb.velocity = Vector3.zero;
            }        
        }
    }

    void OnCollisionEnter2D(Collision2D col) 
    {

        if (col.gameObject.tag == "Bullet")
        {
            maxHealth = maxHealth - 8;
        }

        if(col.gameObject.tag == "Player")
        {
            StartCoroutine(HurtEnemy());
        }

    }

    void OnTriggerStay2D(Collider2D other)
    {
       if(other.gameObject.tag == "Sword" && Input.GetButtonDown("Fire1")){
        maxHealth = maxHealth - 2;
    }   
    }

    private void OnDestroy()
     {

        if(random == 0)
        Instantiate(drop1, transform.position, drop1.transform.rotation);

        if(random == 1)
        Instantiate(drop2, transform.position, drop2.transform.rotation);

     }

    private IEnumerator HurtEnemy()
    {
        GameObject player = GameObject.Find("Player");
        Vector2 direction = transform.position - player.transform.position;
        repelled = true;
        rb.AddForce(direction * repelForce);
        yield return new WaitForSeconds(pushTime);
        rb.velocity = Vector2.zero;
        repelled = false;
    }
}

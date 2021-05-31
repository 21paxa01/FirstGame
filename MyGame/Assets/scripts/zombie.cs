using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour
{
    private Rigidbody2D physik;
    public Transform player;
    public Animator anim;
    public bool fight ;
    public int hp;

    public Transform head_spawn;
    public GameObject head;


    public float speed;
    void Start()
    {
        physik = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);
        if (distToPlayer <= 1.2f)
        {
            physik.velocity = new Vector2(0, 0);
            fight = true;
        }
        else
        {
            fight = false;
        }
        anim.SetBool("fight", fight);


        if (player.position.x < transform.position.x && distToPlayer>1.2)
        {
            physik.velocity = new Vector2(-speed,0);
            transform.localScale = new Vector2(-1, 1);
        }
        if (player.position.x > transform.position.x&&distToPlayer>1.2)
        {
            physik.velocity = new Vector2(+speed, 0);
            transform.localScale = new Vector2(1, 1);
        }
    }
    int a = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "pistol_bullet(Clone)")
        {
            Destroy(other.gameObject);
            a += 1;
            if (a == hp)
            {
                a = 0;
                Destroy(gameObject);
            }
        }
    }


}
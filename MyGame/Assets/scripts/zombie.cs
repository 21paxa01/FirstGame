using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour
{
    private Rigidbody2D physik;
    public Transform player;
    public Animator anim;
    public bool fight ;
<<<<<<< HEAD
    public bool death;
    public float death_time;
    public float zombie_damage;
    public float atack_time;
    private float distToPlayer;

=======
    
>>>>>>> parent of 9d58dac (ноум)

    public float speed;
    void Start()
    {
        physik = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    public float dist_to_player;
    void Update()
    {
<<<<<<< HEAD
        distToPlayer = Vector2.Distance(transform.position, player.transform.position);
=======
        float distToPlayer = Vector2.Distance(transform.position, player.position);
>>>>>>> parent of 9d58dac (ноум)
        if (distToPlayer <= dist_to_player)
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
    public int HP;
    private int hp=0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "pistol_bullet(Clone)")
        {
            hp+= 1;
            Destroy(other.gameObject);
            if (hp == HP)
            {
<<<<<<< HEAD
                StartCoroutine(Die());
            }
        }
    }
    
=======
                Destroy(gameObject);
                hp=0;
            }
        }
    }
>>>>>>> parent of 9d58dac (ноум)


}
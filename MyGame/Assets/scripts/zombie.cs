using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zombie : MonoBehaviour
{
    private Rigidbody2D physik;
    public GameObject player;
    public Animator anim;
    public bool fight ;
    public bool death;
    public float death_time;
    public float zombie_damage;
    public float atack_time;
    private int Bar = 1;
    private float distToPlayer;

    public Image bar;
    public float fill;


    public float speed;
    void Start()
    {
        physik = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        fill = 1f;
    }
    public float dist_to_player;
    void Update()
    {
        bar.fillAmount = fill;
        distToPlayer = Vector2.Distance(transform.position, player.transform.position);
        if (distToPlayer <= dist_to_player)
        {
            physik.velocity = new Vector2(0, 0);
            fight = true;
            Bar = 0;
            //StartCoroutine(Bar_damage());
            fill -= zombie_damage;
        }
        else
        {
            fight = false;
        }
        anim.SetBool("fight", fight);


        if (player.transform.position.x < transform.position.x && distToPlayer>dist_to_player&&death==false)
        {
            physik.velocity = new Vector2(-speed,0);
            transform.localScale = new Vector2(-1, 1);
        }
        if (player.transform.position.x > transform.position.x&&distToPlayer>dist_to_player&&death==false)
        {
            physik.velocity = new Vector2(+speed, 0);
            transform.localScale = new Vector2(1, 1);
        }
        if (death == true)
        {
            physik.velocity = new Vector2(0, 0);
        }
    }
    public int HP;
    private int hp=0;
    IEnumerator Die()
    {
        death = true;
        anim.SetBool("death", death);
        yield return new WaitForSeconds(death_time);
        Destroy(gameObject);
        hp = 0;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "pistol_bullet(Clone)")
        {
            hp+= 1;
            Destroy(other.gameObject);
            if (hp == HP)
            {
                StartCoroutine(Die());
            }
        }
    }
    IEnumerator Bar_damage()
    {
        while (Bar < 1)
        {
            yield return new WaitForSeconds(atack_time);
            if (distToPlayer <= dist_to_player)
            {
                fill -= zombie_damage;
                physik.velocity = new Vector2(0, 0);
                fight = true;
            }
            else
            {
                Bar = 1;
                fight = false;
            }
        }
    }


}
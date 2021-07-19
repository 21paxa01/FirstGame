using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
<<<<<<< HEAD
using UnityEngine.UI;
=======
>>>>>>> parent of d90c765 (delete)
=======
using UnityEngine.UI;
>>>>>>> parent of a08bdef (Revert "")

public class zombie : MonoBehaviour
{
    private Rigidbody2D physik;
<<<<<<< HEAD
<<<<<<< HEAD
    public GameObject player;
    public Animator anim;
    public bool fight ;
=======
    public Transform player;
    public Animator anim;
    public bool fight ;

>>>>>>> parent of d90c765 (delete)
=======
    public GameObject player;
    public Animator anim;
    public bool fight ;
>>>>>>> parent of a08bdef (Revert "")
    public bool death;
    public float death_time;
    public float zombie_damage;
    public float atack_time;
<<<<<<< HEAD
    private int Bar = 1;
    private float distToPlayer;

<<<<<<< HEAD
    public Image bar;
    public float fill;
=======
    
    private float distToPlayer;


>>>>>>> parent of d90c765 (delete)

=======
>>>>>>> parent of a08bdef (Revert "")

    public float speed;
    void Start()
    {
        physik = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
<<<<<<< HEAD
        fill = 1f;
=======
        
>>>>>>> parent of d90c765 (delete)
    }
    public float dist_to_player;
    void Update()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        bar.fillAmount = fill;
        distToPlayer = Vector2.Distance(transform.position, player.transform.position);
=======

        

        float distToPlayer = Vector2.Distance(transform.position, player.position);


>>>>>>> parent of d90c765 (delete)
=======
        distToPlayer = Vector2.Distance(transform.position, player.transform.position);
>>>>>>> parent of a08bdef (Revert "")
        if (distToPlayer <= dist_to_player)
        {
            physik.velocity = new Vector2(0, 0);
            fight = true;
<<<<<<< HEAD
            Bar = 0;
            //StartCoroutine(Bar_damage());
            fill -= zombie_damage;
=======
            
            
            
>>>>>>> parent of d90c765 (delete)
        }
        else
        {
            fight = false;
        }
        anim.SetBool("fight", fight);


<<<<<<< HEAD
<<<<<<< HEAD
        if (player.transform.position.x < transform.position.x && distToPlayer>dist_to_player&&death==false)
=======
        if (player.position.x < transform.position.x && distToPlayer>1.2)
>>>>>>> parent of d90c765 (delete)
=======
        if (player.transform.position.x < transform.position.x && distToPlayer>dist_to_player&&death==false)
>>>>>>> parent of a08bdef (Revert "")
        {
            physik.velocity = new Vector2(-speed,0);
            transform.localScale = new Vector2(-1, 1);
        }
<<<<<<< HEAD
<<<<<<< HEAD
        if (player.transform.position.x > transform.position.x&&distToPlayer>dist_to_player&&death==false)
=======
        if (player.position.x > transform.position.x&&distToPlayer>1.2)
>>>>>>> parent of d90c765 (delete)
=======
        if (player.transform.position.x > transform.position.x&&distToPlayer>dist_to_player&&death==false)
>>>>>>> parent of a08bdef (Revert "")
        {
            physik.velocity = new Vector2(+speed, 0);
            transform.localScale = new Vector2(1, 1);
        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of a08bdef (Revert "")
        if (death == true)
        {
            physik.velocity = new Vector2(0, 0);
        }
<<<<<<< HEAD
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
=======
    }
    public int HP;
    private int hp=0;
>>>>>>> parent of d90c765 (delete)
=======
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
>>>>>>> parent of a08bdef (Revert "")
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
<<<<<<< HEAD
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
=======

                Destroy(gameObject);
>>>>>>> parent of d90c765 (delete)
            }
        }
    }
=======
    
>>>>>>> parent of a08bdef (Revert "")

<<<<<<< HEAD
=======
                
               
        


    

>>>>>>> parent of d90c765 (delete)

}
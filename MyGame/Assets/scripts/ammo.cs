using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    public float speed;
    public float destroyTime;
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> parent of de2e956 (123)
    public float death_time;
    public bool death;
    public Animator anim;
    void Start()
    {
        Invoke("DestroyAmmo", destroyTime);
        anim = GetComponent<Animator>();
<<<<<<< HEAD
    }

    
=======

    public float death_time;
    public bool death;
    public Animator anim;


    void Start()
    {
        Invoke("DestroyAmmo", destroyTime);
<<<<<<< HEAD

=======
        rb = GetComponent<Rigidbody2D>();
>>>>>>> parent of a08bdef (Revert "")
=======
>>>>>>> parent of 9d58dac (ноум)
>>>>>>> parent of de2e956 (123)
    }


>>>>>>> parent of d90c765 (delete)
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void DestroyAmmo()
    {
        Destroy(gameObject);
    }
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of a08bdef (Revert "")
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "road u")
        {
            StartCoroutine(Die());
        }
    }
    IEnumerator Die()
    {
        speed = 0;
        death = true;
        anim.SetBool("death", death);
        yield return new WaitForSeconds(death_time);
        Destroy(gameObject);
        
    }

<<<<<<< HEAD
}
=======
=======
>>>>>>> parent of a08bdef (Revert "")
}



>>>>>>> parent of d90c765 (delete)

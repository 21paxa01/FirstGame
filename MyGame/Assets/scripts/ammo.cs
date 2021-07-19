using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    public float speed;
    public float destroyTime;
<<<<<<< HEAD
<<<<<<< HEAD
    public float death_time;
    public bool death;
    public Animator anim;
    void Start()
    {
        Invoke("DestroyAmmo", destroyTime);
        anim = GetComponent<Animator>();
<<<<<<< HEAD
        rb = GetComponent<Rigidbody2D>();
=======
    void Start()
    {
        Invoke("DestroyAmmo", destroyTime);
>>>>>>> parent of 9d58dac (ноум)
=======
    void Start()
    {
        Invoke("DestroyAmmo", destroyTime);
>>>>>>> parent of 9d58dac (ноум)
=======
>>>>>>> parent of 1c1f832 (pasha)
    }

    
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void DestroyAmmo()
    {
        Destroy(gameObject);
    }
    
}

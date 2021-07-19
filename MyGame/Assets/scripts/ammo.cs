using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    public float speed;
    public float destroyTime;
<<<<<<< HEAD
    public float death_time;
    public bool death;
    public Animator anim;
    private Rigidbody2D rb;
    void Start()
    {
        Invoke("DestroyAmmo", destroyTime);
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
=======
    void Start()
    {
        Invoke("DestroyAmmo", destroyTime);
>>>>>>> parent of 9d58dac (ноум)
    }

    
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        var direction = rb.velocity;
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    void DestroyAmmo()
    {
        Destroy(gameObject);
    }
    
}

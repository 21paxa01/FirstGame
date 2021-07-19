using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    public float speed;
    public float destroyTime;

    public float death_time;
    public bool death;
    public Animator anim;


    void Start()
    {
        Invoke("DestroyAmmo", destroyTime);

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




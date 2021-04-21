using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    public float speed;
    public float destroyTime;
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
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "default_zombie(Clone)"|| other.name == "bibo_zombie(Clone)")
        {
            Destroy(other.gameObject);
            DestroyAmmo();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject default_zombie;
    public GameObject bibo_zombie;
    private GameObject zombie;
    public Transform spawn_point_1;
    private Transform spawn_point;
    public Transform spawn_point_2;

    

    Coroutine spawn_zombie;
    public float spawn_time;
    public int i;
    
    void Start()
    {
        
    }


    void Update()
    {
        SpawnPoint();
        Zombies();
        if (Input.GetMouseButtonDown(1))
        {
            a = 0;
            spawn_zombie = StartCoroutine(Spawn());

        }
    }
    public int a = 0;
    IEnumerator Spawn()
    {

        while (a<1)
        {
            Instantiate(zombie,spawn_point.position,transform.rotation);
            yield return new WaitForSeconds(spawn_time);
            if (Input.GetKey(KeyCode.Q))
            {
                a = 2;
                
            }
        }

    }

    void SpawnPoint()
    {
        int spawn_value = Random.Range(0, 2);
        if (spawn_value == 0)
        {
            spawn_point = spawn_point_1;
        }
        else
        {
            spawn_point = spawn_point_2;
        }
    }
    void Zombies()
    {
        int zombie_value = Random.Range(0, 3);
        if (zombie_value == 0)
        {
            zombie = bibo_zombie;
        }
        else
        {
            zombie = default_zombie;
        }
    }
}

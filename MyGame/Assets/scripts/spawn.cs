using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject default_zombie;
    public GameObject bibo_zombie;
<<<<<<< HEAD
    public GameObject bo_zombie;
=======

    public GameObject bo_zombie;

    public GameObject karl_zombie;
    public GameObject lara_zombie;

>>>>>>> parent of d90c765 (delete)
    private GameObject zombie;
    public Transform spawn_point_1;
    private Transform spawn_point;
    public Transform spawn_point_2;
<<<<<<< HEAD
   

    
=======


>>>>>>> parent of d90c765 (delete)

    Coroutine spawn_zombie;
    public float spawn_time;
    public int i;
<<<<<<< HEAD
    
    void Start()
    {
        //Time.timeScale = 0f;
=======

    void Start()
    {

>>>>>>> parent of d90c765 (delete)
    }


    void Update()
    {
        SpawnPoint();
        Zombies();
<<<<<<< HEAD
       
    }
    private int b = 0;
    public void spawn_zombies()
    {
        a = 0;
        if (b < 1)
        {
            spawn_zombie = StartCoroutine(Spawn());
        }
        b = 2;
=======

    }
    public void spawn_zombies()
    {
        a = 0;
        spawn_zombie = StartCoroutine(Spawn());
>>>>>>> parent of d90c765 (delete)
    }
    public int a = 0;
    IEnumerator Spawn()
    {

<<<<<<< HEAD
        while (a<1)
        {
            Instantiate(zombie,spawn_point.position,transform.rotation);
=======
        while (a < 1)
        {
            Instantiate(zombie, spawn_point.position, transform.rotation);
>>>>>>> parent of d90c765 (delete)
            yield return new WaitForSeconds(spawn_time);
            if (Input.GetKey(KeyCode.Q))
            {
                a = 2;
<<<<<<< HEAD
                
=======

>>>>>>> parent of d90c765 (delete)
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
<<<<<<< HEAD
        int zombie_value = Random.Range(0, 9);
        if (zombie_value<1)
        {
            zombie = bo_zombie;
        }
        else if(zombie_value>=2&&zombie_value<5)
        {
            zombie =bibo_zombie;
        }
=======

        int zombie_value = Random.Range(0, 99);
        if (zombie_value < 10)
        {

            zombie = bo_zombie;
        }


        else if (zombie_value >= 10 && zombie_value < 25)
        {

            zombie = bibo_zombie;
        }






        else if (zombie_value >= 25 && zombie_value < 40)
        {
            zombie = karl_zombie;
        }
        else if (zombie_value >= 40 && zombie_value < 55)
        {
            zombie = lara_zombie;
        }




>>>>>>> parent of d90c765 (delete)
        else
        {
            zombie = default_zombie;
        }
<<<<<<< HEAD
=======

>>>>>>> parent of d90c765 (delete)
    }
}

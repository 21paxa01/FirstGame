using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoting : MonoBehaviour
{
  
    public float offset;

    public GameObject zombie;
    public Transform spawn_point;
    Coroutine spawn_zombie;


    public GameObject ammo;
    public Transform shotDir;
    public Joystick joystick;

    private float timeShot;
    public float startTime;
    Coroutine fireFrequency;
    private bool shot;

    public bool faceRight = true;
    void Start()
    {
        
    }
    void Update()
    {
  
        float rotateZ = Mathf.Atan2(joystick.Vertical,joystick.Horizontal) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);
<<<<<<< HEAD
        if (reload == Reload)
        {
            fireFrequency = StartCoroutine(RELOAD());
        }

<<<<<<< HEAD
=======

        
>>>>>>> parent of 9d58dac (ноум)
=======
        
>>>>>>> parent of 9d58dac (ноум)

        Vector3 LocalScale = Vector3.one;
        if (rotateZ > 90 || rotateZ < -90)
        {
            LocalScale.y = -1f;
           
        }
        else
        {
            LocalScale.y = +1f;

        }
        transform.localScale = LocalScale;

        if(joystick.Vertical==0 && joystick.Horizontal == 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, rotateZ);
        }
  
        
        if(joystick.Vertical != 0 || joystick.Horizontal != 0)
        {
            shot = true;
        }
        else
        {
            shot = false;
        }
        if (shot==true)
        {
            i = 0;
            
        }
        
        
    }
<<<<<<< HEAD

    public void Shot()
    {
        if (reload != Reload)
        {
            fireFrequency = StartCoroutine(FireDelay());

        }
=======
    public void Shot()
    {
        fireFrequency = StartCoroutine(FireDelay());
>>>>>>> parent of d97c624 (change5)
    }
    public int i = 0;
    public int Reload;
    private int reload = 0;
    public float ReloadTime;
    IEnumerator FireDelay()
    {
        while (i<10)
        {
            reload += 1;
            Instantiate(ammo, shotDir.position, transform.rotation) ;
            yield return new WaitForSeconds(startTime);
            if (shot==false)
            {
                i=10;
            }
            

        }
        
    }
    IEnumerator RELOAD()
    {
        while (reload == Reload)
        {
            yield return new WaitForSeconds(ReloadTime);
            reload = 0;
        }
    }

    
}

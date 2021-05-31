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

    public bool faceRight = true;
    void Start()
    {
        
    }
    void Update()
    {
  
        float rotateZ = Mathf.Atan2(joystick.Vertical,joystick.Horizontal) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);

        

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
  
        
       
        if (Input.GetMouseButtonDown(1))
        {
            i = 0;
            fireFrequency = StartCoroutine(FireDelay());
        }
        
        
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
            if (Input.GetKey(KeyCode.R))
            {
                i=10;
            }
            if (reload == Reload)
            {
                yield return new WaitForSeconds(ReloadTime);
                reload = 0;
            }

        }
        
    }

    
}

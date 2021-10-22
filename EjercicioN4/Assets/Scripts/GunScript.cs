using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    // Start is called before the first frame update
   
    
    public          GameObject  prefabBullet;
    public float    bulletTime    = 3f;
    public float    startShooting = 0f;
    public float    shootingRatio = 0f;
    
    void Start()
    {             
      InvokeRepeating("shootBullet",startShooting,shootingRatio);    
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    private void shootBullet() 
    {
      Instantiate(prefabBullet,transform.position, prefabBullet.transform.rotation );  
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    // Start is called before the first frame update
   
    public float bulletRatio = 0.0f;
    public GameObject prefabBullet;
    
    void Start()
    {
        
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSript : MonoBehaviour
{
    // Start is called before the first frame update
    public float bulletSpeed = 0.0f;
    public float bulletTime  = 3f;
    public float bulletDestroy = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bulletMovement(Vector3.left);
        bulletDestroy -= Time.deltaTime;
        if (bulletDestroy < 0)
        {
            Destroy(gameObject);
        }
        if (Input.GetKeyDown("space"))
        {

            transform.localScale = transform.localScale * 2;
        }
    }
    private void bulletMovement (Vector3 direction)
    {
        transform.Translate(bulletSpeed * Time.deltaTime * direction);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSript : MonoBehaviour
{
    // Start is called before the first frame update
    public float bulletSpeed = 0.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bulletMovement(Vector3.left);
    }
    private void bulletMovement (Vector3 direction)
    {
        transform.Translate(bulletSpeed * Time.deltaTime * direction);
    }
}

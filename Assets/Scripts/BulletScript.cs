using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject bullet;
    public GameObject gunpoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootBullet();
        }
    }

    private void FixedUpdate()
    {
        
    }

    void ShootBullet()
    {
        GameObject obj = Instantiate(bullet, gunpoint.transform.position, gunpoint.transform.rotation);
        obj.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 0, 10));
    }
}

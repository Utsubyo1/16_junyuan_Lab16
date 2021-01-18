using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotatespeed;

    public GameObject bulletPrefab;
    public GameObject bulletSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, bulletSpawn.transform.position, transform.rotation);
        }
    }

    
}

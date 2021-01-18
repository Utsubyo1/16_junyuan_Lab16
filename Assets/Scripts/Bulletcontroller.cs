using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bulletcontroller : MonoBehaviour
{
    float speed = 5f;
    float Score;
    public GameObject TextScore;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    

    
}

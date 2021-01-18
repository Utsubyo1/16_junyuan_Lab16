using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    public GameObject Text;

    float Score = 0;
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Gamemanager.Instance.AddScore();
            
        }
    }
}

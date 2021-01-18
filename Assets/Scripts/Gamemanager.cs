using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gamemanager : MonoBehaviour
{
    public static Gamemanager Instance;
    public GameObject TextScore;

    float Score;
    // Start is called before the first frame update
    void Start()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore()
    {
        Score++;
        TextScore.GetComponent<Text>().text = "Score: " + Score;
    }
}

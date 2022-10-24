using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (health==0)
        {
            SceneManager.LoadScene("game_over");
        }
        
    }
    public void MinusHealth()
    {
        health -= 1;
        Debug.Log(health);
    }
}

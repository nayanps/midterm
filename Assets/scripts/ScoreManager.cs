using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    //percentage score 
    int percentage = 100;

    //changing sprites for percentage number on top
    public SpriteRenderer spriteRenderer;
    public Sprite hundred;
    public Sprite ninety;
    public Sprite eighty;
    public Sprite seventy;
    public HealthManager healthManager;

    void Awake()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }
    void Update()
    { //changes percentage
        if (percentage == 100)
        {
            spriteRenderer.sprite = hundred;
        }
        else if (percentage == 90)
        {
            spriteRenderer.sprite = ninety;
        }
        else if (percentage == 80)
        {
            spriteRenderer.sprite = eighty;
        }
        else if (percentage == 70) //change to == later
        {
            spriteRenderer.sprite = seventy;
        }
        else if (percentage < 70) //change to == later
        {
            SceneManager.LoadScene("desk");
            healthManager.MinusHealth();

        }

    }

    public void MinusPercent()
    {
        percentage -= 10;
    }
}

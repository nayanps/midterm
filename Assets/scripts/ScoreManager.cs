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
    public AudioSource chime;
    bool played=false;
    bool played2=false;
    bool played3 = false;
    

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
            if (!played) 
            {
                play_sound();
                played=true;
            }
            spriteRenderer.sprite = ninety;
        }
        else if (percentage == 80)
        {
            if (!played2)
            {
                play_sound();
                played2 = true;
            }
            spriteRenderer.sprite = eighty;
        }
        else if (percentage == 70) //change to == later
        {
            if (!played3)
            {
                play_sound();
                played3 = true;
            }
            spriteRenderer.sprite = seventy;
        }
        else if (percentage < 70) //change to == later
        {
            SceneManager.LoadScene("desk");
            healthManager.MinusHealth();

        }

    }

    public void play_sound()
    {
        chime.Play();
    }

    public void MinusPercent()
    {
        percentage -= 10;
    }
}

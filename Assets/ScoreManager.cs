using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    //percentage score 
    //remember to add penalty to assignment_col!!! or this will literally do nothing lol
    int percentage = 100;

    //changing sprites for percentage number on top
    public SpriteRenderer spriteRenderer;
    public Sprite hundred;
    public Sprite ninety;
    public Sprite eighty;
    public Sprite seventy;

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
        else if (percentage <= 70) //change to == later
        {
            spriteRenderer.sprite = seventy;
        }

        //add room change and overall lives count

    }

    public void MinusPercent()
    {
        percentage -= 10;
    }
}

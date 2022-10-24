using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class RoomHealthTracker : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite three;
    public Sprite two;
    public Sprite one;
    public GameObject health;
    private HealthManager hm;

    private void Start()
    {
        health = GameObject.Find("Health");
        hm = health.GetComponent<HealthManager>();

    }

    // changing room
    void Update()
    {
        if (hm.health == 3)
        {
            spriteRenderer.sprite = three;
        }
        else if (hm.health == 2)
        {
            spriteRenderer.sprite = two;
        }
        else if (hm.health == 1)
        {
            spriteRenderer.sprite = one;
        }

    }
}

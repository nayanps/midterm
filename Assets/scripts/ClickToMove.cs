using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToMove : MonoBehaviour
{
    public String new_room;
    public AudioSource click;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ClickMove());
            
        }
    }
    IEnumerator ClickMove()
    {
        while (true)
        {
            click.Play();
            yield return new WaitForSeconds(1f);
            SceneManager.LoadScene(new_room);
            yield break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ITMouseClick : MonoBehaviour
{
    public AudioSource click;
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            click.Play();
            Destroy(gameObject);
            ITManager.instance.ClickIT();
        }
    }
}

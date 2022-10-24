using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(WaitTime());
    }

    IEnumerator WaitTime()
    { //goes to title screen after 10s
        while (true)
        {
            yield return new WaitForSeconds(10f);
            SceneManager.LoadScene("title_screen");
        }
    }
}

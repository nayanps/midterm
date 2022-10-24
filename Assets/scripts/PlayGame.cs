using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.VisualScripting.Member;

public class PlayGame : MonoBehaviour
{
    public AudioSource ding;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(PressPlay());

        }

    }
    IEnumerator PressPlay()
    {
        while (true)
        {
           ding.Play();
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("room");
            yield break;
        }
    }
}

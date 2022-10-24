using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource enter;
    private AudioSource _audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void PlayDing()
    {
        enter.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            PlayDing();

        }

    }
}

using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]public int _countdownMinutes = default;
    private float _countdownSeconds;
    private Text _timer;
    AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _timer = GetComponent<Text>();
        _countdownSeconds = _countdownMinutes * 60;

    }

    void Update()
    {
        _countdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)_countdownSeconds);
        _timer.text = span.ToString(@"mm\:ss");

        if (_countdownSeconds <= 0)
        {
            Debug.Log("TIMEUP");
            _audioSource.Play();
            SceneManager.LoadScene("ResultScene", LoadSceneMode.Single);
        }
    }

}

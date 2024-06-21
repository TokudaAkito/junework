using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]public int _countdownMinutes = 2;
    private float _countdownSeconds;
    private Text _timer;

    private void Start()
    {

        _timer = GetComponent<Text>();
        _countdownSeconds = _countdownSeconds * 60;

    }

    private void Update()
    {
        _countdownSeconds -= Time.deltaTime;
        var Span = new TimeSpan(0, 0, (int)_countdownSeconds);
        _timer.text = Span.ToString(@"mm\:ss");

        if (_countdownSeconds <= 0)
        {
            Debug.Log("TIMEUP");
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text _scoreText = null;
    private int _oldScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        _scoreText = GetComponent<Text>();
        if (GameManager._instance != null)
        {
            _scoreText.text = $"{GameManager._instance._score}";
        }
        else
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_oldScore != GameManager._instance._score)
        {
            _scoreText.text = $"{GameManager._instance._score}";
        }
    }
}

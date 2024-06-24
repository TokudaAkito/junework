using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class GameScore : MonoBehaviour
{
    private static GameScore _instance;
    public static GameScore Instance => _instance;

    public int _score = 0;

    private void Awake()
    {
        //_instanceがすでにあったら自分を消す
        if (_instance && this != _instance)
        {
            Destroy(this.gameObject);
        }

        _instance = this;

        //Scene遷移で消えないようにする
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        Debug.Log(_score);
    }
}

//GameScene側
public class ScoreChanger
{
    public void ScorePlus()
    {
        GameScore.Instance._score++;
    }
}

//ResultScene側
public class ScoreGetter
{
    public string GetScore()
    {
        return GameScore.Instance._score.ToString();   
    }
}

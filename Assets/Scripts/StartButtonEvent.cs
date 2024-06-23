using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //クリックイベント：ボタンをクリックすると"Start"を表示する
    public void OnClickEvent()
    {
        Debug.Log("Start");
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
}

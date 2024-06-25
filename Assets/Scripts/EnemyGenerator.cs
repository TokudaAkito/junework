using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject[] _enemyPrefab;
    [SerializeField] public float _spownInterval;
    private float _time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _enemyPrefab.Length; i++)
        {
            float randomX = Random.Range(-50, 50);
            float randomY = Random.Range(-50, 50);
            GameObject enemy = Instantiate(_enemyPrefab[i]);
            enemy.transform.position = new Vector3(randomX, randomY, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;

        if (_time > _spownInterval)
        {
            for (int i = 0; i < _enemyPrefab.Length; i++)
            {
                float randomX = Random.Range(-50, 50);
                float randomY = Random.Range(-50, 50);
                GameObject enemy = Instantiate(_enemyPrefab[i]);
                enemy.transform.position = new Vector3(randomX, randomY, 0f);
            }
            _time = 0f;
        }
    }
}

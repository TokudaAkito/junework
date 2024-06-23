using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyManager : MonoBehaviour
{
    //最大HPと現在のHP
    [SerializeField] int _maxHp = default;
    int _hp;
    //Sliderを入れる
    public Slider _slider;
    //現在のダメージ
    private int _damage = 0;
    //ダメージを受けているかの判定
    bool _getdamage = false;

    private void Start()
    {
        _slider.value = 1;
        _hp = _maxHp;
        Debug.Log($"スタートHP:{_hp}");
    }

    private void Update()
    {
        if (!_getdamage)
        {
            return;
        }
        if (_getdamage)
        {
            _hp -= _damage;
            Debug.Log($"{_hp}");
            _slider.value = (float)_hp / (float)_maxHp;
        }
        if (_hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void GetDamage(int _damage)
    {
        this._damage += _damage;
        _getdamage = true;
    }
}

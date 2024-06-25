using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


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
    //死んだかどうかの判定
    public bool _isDeadEnemy = false;

    private void Start()
    {
        _slider.value = 1;
        _hp = _maxHp;
        //this.transform.DOMove(new Vector3(0f, 0f, 0f), 10f).SetLoops(5, LoopType.Yoyo);
    }

    void Update()
    {
        if (!_getdamage)
        {
            return;
        }
        if (_hp <= 0)
        {
            Dead();
        }
    }

    public void GetDamage(int _damage)
    {
        this._damage += _damage;
        _getdamage = true;
        _hp -= _damage;
        Debug.Log($"{_hp}");
        _slider.value = (float)_hp / (float)_maxHp;
    }

    void Dead()
    {
        Destroy(this.gameObject);
        GameManager._instance._score += 1;
    }
}

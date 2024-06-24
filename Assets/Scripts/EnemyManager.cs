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
    //死んだかどうかの判定
    public bool _isDeadEnemy = false;

    ScoreChanger scoreChanger;
    private void Start()
    {
        _slider.value = 1;
        _hp = _maxHp;
        Debug.Log($"スタートHP:{_hp}");
    }

    void Update()
    {
        if (!_getdamage)
        {
            return;
        }
        if (_hp <= 0)
        {
            _isDeadEnemy = true;
            scoreChanger.ScorePlus();
            //this.gameObject.SetActive(false);
            Destroy( this.gameObject );
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
}

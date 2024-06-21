using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyManager : MonoBehaviour
{
    //最大HP
    [SerializeField] private int _maxHp = 100;
    //HP
    private int _hp;
    //HP表示用UI
    [SerializeField] GameObject _hpUI;
    //HP表示用スライダー
    Slider _hpSlider;
    //現在のダメージ量
    private int _damage = 0;

    private void Start()
    {
        _hp = _maxHp;
        _hpSlider = _hpUI.transform.Find("HPBar").GetComponent<Slider>();
        _hpSlider.value = 1f;
    }

    public void SetHp(int _hp)
    {
        this._hp = _hp;
        //HP表示用UIのアップデート
        UpdateHpValue();
    }

    public int GetHp()
    {
        return _hp;
    }

    public int GetMaxHp()
    {
        return _maxHp;
    }

    public void UpdateHpValue()
    {
        _hpSlider.value = (float)GetHp() / (float)GetMaxHp();
    }

    public void GetDamage(int _damage)
    {
        this._damage += _damage;
    }

    ////HP
    //[SerializeField]private int _hp = 10;
    ////HPを表示するテキスト
    //private Text _hpText;
    //void Start()
    //{
    //    _hpText = GetComponentInChildren<Text>();
    //    _hpText.text = _hp.ToString();
    //}

    //private void Update()
    //{
    //    if (_damage == 0)
    //    {
    //        return;
    //    }

    //    //　ダメージ量をHPから減らす
    //    int tempDamage = _damage;
    //    _hp -= tempDamage;
    //    _hpText.text = _hp.ToString();
    //    _damage -= tempDamage;

    //    //　HPが0以下になったら敵を削除
    //    if (_hp <= 0)
    //    {
    //        Destroy(gameObject);
    //    }
    //}

}

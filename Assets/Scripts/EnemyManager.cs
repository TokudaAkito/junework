using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyManager : MonoBehaviour
{
    //HP
    [SerializeField]private int _hp = 10;
    //HPを表示するテキスト
    private Text _hpText;
    //現在のダメージ量
    private int _damage = 0;
    void Start()
    {
        _hpText = GetComponentInChildren<Text>();
        _hpText.text = _hp.ToString();
    }

    private void Update()
    {
        if (_damage == 0)
        {
            return;
        }

        //　ダメージ量をHPから減らす
        int tempDamage = _damage;
        _hp -= tempDamage;
        _hpText.text = _hp.ToString();
        _damage -= tempDamage;

        //　HPが0以下になったら敵を削除
        if (_hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void GetDamage(int _damage)
    {
        this._damage += _damage;
    }
}

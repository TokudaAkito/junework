using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyManager : MonoBehaviour
{
    //HP
    [SerializeField]private int _hp = 10;
    //HP��\������e�L�X�g
    private Text _hpText;
    //���݂̃_���[�W��
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

        //�@�_���[�W�ʂ�HP���猸�炷
        int tempDamage = _damage;
        _hp -= tempDamage;
        _hpText.text = _hp.ToString();
        _damage -= tempDamage;

        //�@HP��0�ȉ��ɂȂ�����G���폜
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

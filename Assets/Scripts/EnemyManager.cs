using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyManager : MonoBehaviour
{
    //�ő�HP
    [SerializeField] private int _maxHp = 100;
    //HP
    private int _hp;
    //HP�\���pUI
    [SerializeField] GameObject _hpUI;
    //HP�\���p�X���C�_�[
    Slider _hpSlider;
    //���݂̃_���[�W��
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
        //HP�\���pUI�̃A�b�v�f�[�g
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
    ////HP��\������e�L�X�g
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

    //    //�@�_���[�W�ʂ�HP���猸�炷
    //    int tempDamage = _damage;
    //    _hp -= tempDamage;
    //    _hpText.text = _hp.ToString();
    //    _damage -= tempDamage;

    //    //�@HP��0�ȉ��ɂȂ�����G���폜
    //    if (_hp <= 0)
    //    {
    //        Destroy(gameObject);
    //    }
    //}

}

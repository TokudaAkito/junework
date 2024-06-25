using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Transform target;
    bool _pushed=false;    //GetKeyDownが使えなかったため、キーが押されているかの判定
    [SerializeField] public int _attackDamage;    //攻撃力
    //攻撃のインターバル
    [SerializeField] public float _attackSpeed;     //アタックスピード  
    float _cooltime;
    bool _isAttackable = true;   //攻撃できるかできないか
    AudioSource _audioSource;
    private void Start()
    {
        _cooltime = 0.0f;
        _audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        this.transform.position = target.position;
        if(!Input.GetKey(KeyCode.Q)) _pushed = false;
        if (!_isAttackable)
        {
            _cooltime += Time.deltaTime;
            if (_cooltime >= _attackSpeed)
            {
                _isAttackable = true;
                _cooltime = 0.0f;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("Touch");
        if (collision.tag == "Enemy" && Input.GetKey(KeyCode.Q) && !_pushed　&& _isAttackable)
        {
            _pushed = true;
            Debug.Log("Attack");
            collision.GetComponent<EnemyManager>().GetDamage(_attackDamage);
            _audioSource.Play();
            _isAttackable = false;
        }
    }

}

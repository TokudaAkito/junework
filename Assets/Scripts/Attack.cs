using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Transform target;
    bool _pushed=false;
    private void Update()
    {
        this.transform.position = target.position;
        if(!Input.GetKey(KeyCode.Q)) _pushed = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("Touch");
        if (collision.tag == "Enemy" && Input.GetKey(KeyCode.Q) && !_pushed)
        {
            _pushed = true;
            Debug.Log("Attack");
            collision.GetComponent<EnemyManager>().GetDamage(1);
        }
    }

}

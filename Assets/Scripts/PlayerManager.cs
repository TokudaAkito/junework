
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    ////�C���x���g���̃X���b�g
    //GameObject[] _slot;
    ////�A�C�e���̃C���[�W
    //Image[] _slotimage;
     
    //�ړ���̍��W�i�[�p
    private Vector3 _pos;
    [SerializeField] float m_near = 1f;
    [SerializeField] float m_speed = 1f;

    void Start()
    {
        //_slot[0] = GameObject.Find("Slot1");
        //_slot[1] = GameObject.Find("Slot2");
        //_slot[2] = GameObject.Find("Slot3");
        //_slotimage[0] = _slot[0].GetComponent<Image>();
        //_slotimage[1] = _slot[1].GetComponent<Image>();
        //_slotimage[2] = _slot[2].GetComponent<Image>();
    }


    void Update()
    {
        //�v���C���[�̈ړ�
        Move();
    }


    private void FixedUpdate()
    {
        //�v���C���[�̈ړ�
        Playermove();
    }

    void Move()
    {
        //�N���b�N���ꂽ��
        if (Input.GetMouseButtonDown(1))
        {
            //�ړ���̍��W���擾
            _pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _pos.z = 0f;
            Debug.Log(_pos);

        }
    }

    void Playermove()
    {
        var distance = _pos - transform.position;

        if (distance.sqrMagnitude > m_near * m_near)
        {
            transform.position += (distance).normalized * m_speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.tag == "Item")
        //{
        //    SpriteRenderer ItemImage = collision.GetComponent<SpriteRenderer>();
        //    if (_slotimage[0] == null)
        //    {
        //        _slotimage[0].sprite = ItemImage.sprite;
        //    }
        //    else if (_slotimage[1] == null)
        //    {
        //        _slotimage[1].sprite = ItemImage.sprite;
        //    }
        //    else
        //    {
        //        _slotimage[2].sprite = ItemImage.sprite;
        //    }
        //    collision.gameObject.SetActive(false);
        //}

        if (collision.tag == "Enemy")
        {
            Debug.Log("GAMEOVER");
        }
    }

}


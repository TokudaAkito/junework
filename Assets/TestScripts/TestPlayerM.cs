
using UnityEngine;
using UnityEngine.UI;

public class TestPlayerM : MonoBehaviour
{
    Rigidbody2D _rb2d;
    GameObject _slot;
    Image _slotimage;

    //�ړ���̍��W�i�[�p
    private Vector3 _pos;
    [SerializeField] float m_near = 1f;
    [SerializeField] float m_speed = 1f;


    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _slot = GameObject.Find("Image");
        _slotimage = _slot.GetComponent<Image>();
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
        if (collision.tag == "Item")
        {
            SpriteRenderer itemImage = collision.GetComponent<SpriteRenderer>();
            _slotimage.sprite = itemImage.sprite;
        }
    }
}


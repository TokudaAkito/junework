using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    ////�C���x���g���̃X���b�g
    //GameObject[] _slot;
    ////�A�C�e���̃C���[�W
    //Image[] _slotimage;
     
    //�ړ��p
    private Vector3 _pos;
    [SerializeField] float m_near = 1f;
    [SerializeField] float m_speed = 1f;
    AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
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
        if (collision.tag == "Enemy")
        {
            Debug.Log("GAMEOVER");
            _audioSource.Play();
            SceneManager.LoadScene("GameOverScene", LoadSceneMode.Single);
        }
        if (collision.tag == "PowerUp")
        {
            Destroy(collision);
        }
        if (collision.tag == "SpeedUp")
        {
            Destroy(collision);
        }
    }

}


using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    ////インベントリのスロット
    //GameObject[] _slot;
    ////アイテムのイメージ
    //Image[] _slotimage;
     
    //移動用
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
        //プレイヤーの移動
        Move();
    }


    private void FixedUpdate()
    {
        //プレイヤーの移動
        Playermove();
    }

    void Move()
    {
        //クリックされた時
        if (Input.GetMouseButtonDown(1))
        {
            //移動先の座標を取得
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


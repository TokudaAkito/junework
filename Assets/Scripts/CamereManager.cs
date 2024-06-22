using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamereManager : MonoBehaviour
{
    public Transform _target;
    public Transform _reset;
    [SerializeField]public float _speed = default;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position + new Vector3(0, 0, -10), _speed * Time.deltaTime); // ÉJÉÅÉâzÇÃà íu
        ResetCamera();
    }

    private void ResetCamera()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = new Vector3(_reset.position.x, _reset.position.y, _reset.position.z);
        }
    }
}

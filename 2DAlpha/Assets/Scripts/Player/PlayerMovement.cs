using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _horizontal;
    [SerializeField]
    private float _vertical;
    [SerializeField]
    private Vector2 _direction;

    private void Update()
    {
        Move();

    }


    private void Move()

    {
        _vertical = Input.GetAxis("Vertical");
        _horizontal = Input.GetAxis("Horizontal");
        _direction =new Vector2 (_horizontal, _vertical);
        transform.Translate(_direction * Time.deltaTime * _speed);


    }
}

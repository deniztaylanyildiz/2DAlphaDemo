using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : MonoBehaviour
{
    private Vector3 _mousePos;
    private Camera _mainCamera;
    private Rigidbody2D rb;
    [SerializeField]
    private float _force;

    private void Start()
    {
        _mainCamera= GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb= GetComponent<Rigidbody2D>();
        _mousePos=_mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = _mousePos - transform.position;
        Vector3 rotation = transform.position - _mousePos;
        rb.linearVelocity = new Vector2(direction.x, direction.y).normalized*_force;
        float rot=Mathf.Atan2(rotation.x, rotation.y)*Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }

   

    public void Shoot()
    {
    
    }
}

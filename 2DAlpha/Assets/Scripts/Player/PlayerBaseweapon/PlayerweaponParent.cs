using System.Threading;
using UnityEngine;

public class PlayerweaponParent : MonoBehaviour
{

    [SerializeField]
    private Vector3 _mausepos;
    [SerializeField]
    private Camera _mainCamera;
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    private Transform _bullettransform;
    [SerializeField]
    private bool _isCantShoot=false;
    [SerializeField]
    private float _shootTimer;
    public float timer;

    private void Awake()
    {
        _mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }


    // Update is called once per frame
    void Update()
    {
        TakingAim();
        shoot();
        MyTimer();
    }

    void TakingAim()
    {
        _mausepos = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = _mausepos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
    void shoot()
    {
        if (Input.GetMouseButtonDown(0) && _isCantShoot == false)
        {
            Instantiate(_bullet, _bullettransform.position, Quaternion.identity);
            _isCantShoot = true;

            
        }
       
            
        

    }
    void MyTimer()
    {
      
        if (_isCantShoot) { 
            timer += Time.deltaTime;
            Debug.Log("2");
        }
        if (_shootTimer <= timer)
        {
            _isCantShoot = false;
            timer = 0;


        }
      

    }
}

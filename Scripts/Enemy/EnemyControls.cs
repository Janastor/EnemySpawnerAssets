using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Enemy))]

public class EnemyControls : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private Rigidbody2D _rb;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }
}

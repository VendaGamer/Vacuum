using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float Speed;
    void Start()
    {
    }
    void Update()
    {
        Movement();

    }
    private void Movement()
    {
        transform.position += Vector3.forward * Speed * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            transform.Rotate(Vector3.right);
        }
    }
}

using System.Collections;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private Scenator scenator;
    [SerializeField]
    private float Speed;
    private Vector3 direction;
    void Start()
    {
        direction= Vector3.forward;
        Time.timeScale = 0;
    }
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        transform.position += direction * (Speed * Time.deltaTime);
    }
    IEnumerator WaitForReturn(Vector3 temp)
    {
        direction = -direction;
        Speed --;
        yield return new WaitForSeconds(1);
        Speed++;
        transform.Rotate(Vector3.right);
        direction = temp;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == null)return;
        if (collision.gameObject.tag == "Item")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Obstacle")
        {
            if (direction == Vector3.forward)
            {
                StartCoroutine(WaitForReturn(Vector3.right));
            }
            else if (direction == Vector3.right)
            {
                StartCoroutine(WaitForReturn(-Vector3.forward));
            }
            else if (direction == -Vector3.forward)
            {
                StartCoroutine(WaitForReturn(-Vector3.right));
            }
            else
            {
                StartCoroutine(WaitForReturn(Vector3.forward));
            }

        }
        else if(collision.gameObject.tag =="Border")
        {
            Destroy(gameObject);
        }
        else if( collision.gameObject.tag == "End")
        {
            scenator.LoadNext();
        }
    }

}

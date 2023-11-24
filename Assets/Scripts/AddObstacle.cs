using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddObstacle : MonoBehaviour
{
    Camera cam;
    [SerializeField]
    GameObject obstacle;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, 100))
            {
                Instantiate(obstacle,hit.point,Quaternion.identity);
            }
        }
    }
}

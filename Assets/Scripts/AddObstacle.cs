using UnityEngine;

public class AddObstacle : MonoBehaviour
{
    Camera cam;
    [SerializeField]
    Rigidbody obstacle;
    void Start()
    {
        cam = this.GetComponent<Camera>();
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

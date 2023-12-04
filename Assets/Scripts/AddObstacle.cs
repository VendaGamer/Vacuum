using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class AddObstacle : MonoBehaviour
{
    Camera cam;
    [SerializeField]
    Rigidbody obstacle;
    [SerializeField]
    GameObject transparent_obst;
    Vector3 old;
    Vector3[,] position = new Vector3[4,6];
    void Start()
    {
        for (int i = 0;i<4;i++)
        {
            for(int j = 0; j < 6; j++)
            {
                
            }
        }
        cam = this.GetComponent<Camera>();
        transparent_obst = Instantiate(transparent_obst, transparent_obst.transform.position, Quaternion.identity);
    }

    void Update()
    {

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit, 100)&& old !=hit.point )
        {
            old = hit.point;
            transparent_obst.transform.position = new Vector3(hit.point.x, transparent_obst.transform.position.y, hit.point.z);
        }
        if(Input.GetMouseButtonDown(1))
        {
            Instantiate(obstacle, hit.point, Quaternion.identity);
        }
    }
}

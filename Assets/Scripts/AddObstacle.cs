using System.Collections.Generic;
using UnityEngine;

public class AddObstacle : MonoBehaviour
{ 
    private Camera cam;
    [SerializeField]
    private Rigidbody obstacle;
    [SerializeField]
    private GameObject transparent_obst;
    [SerializeField]
    private int minDistance;
    private Vector3 old;
    private List<Rigidbody> obstacles = new List<Rigidbody>();
    void Start()
    {
        cam = this.GetComponent<Camera>();
        transparent_obst = Instantiate(transparent_obst, new Vector3(0,-10,0), Quaternion.identity);
    }

    void Update()
    {

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit hit, 100)&& hit.point.x<=16.2&& hit.point.x >= -16.2
            && hit.point.z <= 10 && hit.point.z >= -10) {
            if (Colliding(hit.point, minDistance))
            {
                if (old != hit.point && hit.collider.gameObject.tag != "Obstacle")
                {
                    var boi= new Vector3(hit.point.x, 0, hit.point.z);
                    old = boi;
                    transparent_obst.transform.position = boi;
                }
                if(Input.GetMouseButtonDown(1))
                {
                    var o = Instantiate(obstacle, new Vector3(hit.point.x, 0, hit.point.z), Quaternion.identity);
                    obstacles.Add(o);
                }
            }
            else if(Input.GetMouseButtonDown(1)) {
                var o = Instantiate(obstacle, new Vector3(old.x, 0, old.z), Quaternion.identity);
                obstacles.Add(o);
            }

        }
    }

    private bool Colliding(Vector3 position, float minDistance)
    {
        if(obstacles.Count == 0)
        {
            return true;
        }
        foreach (var existingPosition in obstacles)
        {
            if (Vector3.Distance(position, existingPosition.transform.position) < minDistance)
            {
                return false;
            }
        }
        return true;
    }
}

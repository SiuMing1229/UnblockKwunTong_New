using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_Test01 : MonoBehaviour
{
    [SerializeField] private float rayDistance;
    [SerializeField] private bool centerRayHit;
    [SerializeField] private bool leftRayHit;
    [SerializeField] private bool rightRayHit;
    public bool isHit;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray rayCenter = new Ray(new Vector3(transform.position.x, transform.position.y + 1, transform.position.z ), transform.forward);
        //Ray rayRight = new Ray(new Vector3(transform.position.x+1, transform.position.y, transform.position.z ), transform.forward);
        //Ray rayLeft = new Ray(new Vector3(transform.position.x-1, transform.position.y, transform.position.z), transform.forward);
        //RaycastHit hitInfo;
        centerRayHit = Sencer(rayCenter);
        //rightRayHit = Sencer(rayRight);
        //leftRayHit = Sencer(rayLeft);

        if(centerRayHit || leftRayHit || rightRayHit)
        {
            isHit = true;
        }
        else
        {
            isHit = false;
        }
        
    }

    public bool Sencer(Ray ray)
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, rayDistance))
        {
            //print(hitInfo.collider.gameObject.name);
            Debug.DrawLine(ray.origin, hitInfo.point, Color.red);
            return true;
        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * rayDistance, Color.green);
            return false;
        }
    }

    private bool CheckHited(Ray ray)
    {
        return Physics.Raycast(ray, rayDistance);
    }
}

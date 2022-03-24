using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_Ver2 : MonoBehaviour
{
    [SerializeField] private float rayDistance;
    public bool isHit;

    //public GameObject target;
    //public CarMovementController_Ver02 target;
    Transform hitCar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.forward);
        RaycastHit hitTarget;
        //isHit = Sencer(ray);

        if (Physics.Raycast(ray, out hitTarget, rayDistance))
        {
            Debug.DrawLine(ray.origin, hitTarget.point, Color.red);
            isHit = true;
            hitCar = hitTarget.transform;
            hitCar.GetComponent<CarMovementController_Ver02>().normalMode = false;
            hitCar.GetComponent<CarMovementController_Ver02>().stopMode = true;
        }
        else
        {
            isHit = false;
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * rayDistance, Color.green);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class VRLaserPointer : MonoBehaviour
{
    public SteamVR_Input_Sources type;
    public SteamVR_Behaviour_Pose controllerPose;
    public SteamVR_Action_Boolean teleport;
    public GameObject laserPrefab;
    GameObject laser;
    Transform laserTransform;
    Vector3 hitPoint;

    public Transform cameraRigTransform;
    public GameObject teleportReticlePrefab;
    private GameObject reticle;
    private Transform teleportReticleTransform;
    public Transform headTransform;
    public Vector3 teleportReticleOffset;
    public LayerMask teleportMask;
    private bool shouldTeleport;

    // Start is called before the first frame update
    void Start()
    {
        laser = Instantiate(laserPrefab);
        laserTransform = laser.transform;
        //reticle = Instantiate(teleportReticlePrefab);
        //teleportReticleTransform = reticle.transform;
    }
    // Update is called once per frame
    void Update()
    {
        if (teleport.GetState(type))
        {
            RaycastHit hit;
            if (Physics.Raycast(controllerPose.transform.position, transform.forward, out hit, 100, teleportMask))
            {
                hitPoint = hit.point;
                ShowLaser(hit);
                //reticle.SetActive(true);
                //teleportReticleTransform.position = hitPoint + teleportReticleOffset;
                //shouldTeleport = true;
            }
        }
        else
        {
            laser.SetActive(false);
            //reticle.SetActive(false);
        }
    }
        private void ShowLaser(RaycastHit hit)
    {
        laser.SetActive(true);
        laserTransform.position = Vector3.Lerp(controllerPose.transform.position, hitPoint, .5f);
        laserTransform.LookAt(hitPoint);
        laserTransform.localScale = new Vector3(laserTransform.localScale.x,
                                                laserTransform.localScale.y,
                                                hit.distance);
    }
}

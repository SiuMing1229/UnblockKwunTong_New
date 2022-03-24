using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/*
[InitializeOnLoad()]
public class WayPointEditor
{
    [DrawGizmo(GizmoType.NonSelected | GizmoType.Selected | GizmoType.Pickable)]
    public static void OnDrawSceneGizmo(WayPoint wayPoint, GizmoType gizmoType)
    {
        if((gizmoType & GizmoType.Selected) != 0 )
        {
            Gizmos.color = Color.yellow;
        }
        else
        {
            Gizmos.color = Color.yellow * 0.5f;
        }
        Gizmos.DrawSphere(wayPoint.transform.position, 0.1f);

        Gizmos.color = Color.white;
        Gizmos.DrawLine(wayPoint.transform.position + (wayPoint.transform.right * wayPoint.width / 2f),
            wayPoint.transform.position - (wayPoint.transform.right * wayPoint.width / 2f));

        if(wayPoint.previousWayPoint != null)
        {
            Gizmos.color = Color.red;
            Vector3 offset = wayPoint.transform.right * wayPoint.width / 2f;
            Vector3 offsetTo = wayPoint.previousWayPoint.transform.right * wayPoint.previousWayPoint.width / 2f;

            Gizmos.DrawLine(wayPoint.transform.position + offset, wayPoint.previousWayPoint.transform.position + offsetTo);
        }

        if (wayPoint.nextWayPoint != null)
        {
            Gizmos.color = Color.green;
            Vector3 offset = wayPoint.transform.right * -wayPoint.nextWayPoint.width / 2f;
            Vector3 offsetTo = wayPoint.nextWayPoint.transform.right * -wayPoint.nextWayPoint.width / 2f;
            
           Gizmos.DrawLine(wayPoint.transform.position + offset, wayPoint.nextWayPoint.transform.position + offsetTo);
        }
    }
}
*/
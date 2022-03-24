using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/*
public class WayPointManagerWindow : EditorWindow
{
    [MenuItem("Tools/WayPoint Editor")]
    public static void Open()
    {
        GetWindow<WayPointManagerWindow>();
    }

    public Transform wayPointRoot;

    private void OnGUI()
    {
        SerializedObject obj = new SerializedObject(this);
        EditorGUILayout.PropertyField(obj.FindProperty("wayPointRoot"));
        if (wayPointRoot == null)
        {
            EditorGUILayout.HelpBox("Root tranform must be selected. Please assign a root transform", MessageType.Warning);
        }
        else
        {
            EditorGUILayout.BeginVertical("box");
            DrawButtons();
            EditorGUILayout.EndVertical();
        }

        obj.ApplyModifiedProperties();
    }

    void DrawButtons()
    {
        if(GUILayout.Button("Create WayPoint"))
        {
            CreateWayPoint();
        }

        if(Selection.activeGameObject != null && Selection.activeGameObject.GetComponent<WayPoint>())
        {
            if(GUILayout.Button("Create WayPoint Before"))
            {
                CreateWayPointBefore();
            }
            if(GUILayout.Button("Create WayPoint After"))
            {
                CreateWayPointAfter();
            }
            if(GUILayout.Button("Remove WayPoint"))
            {
                RemoveWayPoint();
            }
        }
    }

    void CreateWayPoint()
    {
        GameObject wayPointObject = new GameObject("WayPoint " + wayPointRoot.childCount, typeof(WayPoint));
        wayPointObject.transform.SetParent(wayPointRoot, false);

        WayPoint wayPoint = wayPointObject.GetComponent<WayPoint>();
        if (wayPointRoot.childCount > 1)
        {
            wayPoint.previousWayPoint = wayPointRoot.GetChild(wayPointRoot.childCount - 2).GetComponent<WayPoint>();
            wayPoint.previousWayPoint.nextWayPoint = wayPoint;
            //Place the wayPoint at the last position
            wayPoint.transform.position = wayPoint.previousWayPoint.transform.position;
            wayPoint.transform.forward = wayPoint.previousWayPoint.transform.forward;
            
        }

        Selection.activeGameObject = wayPoint.gameObject;

    }

    void CreateWayPointBefore()
    {
        GameObject wayPointObject = new GameObject("WayPoint " + wayPointRoot.childCount, typeof(WayPoint));
        wayPointObject.transform.SetParent(wayPointRoot, false);

        WayPoint newWayPoint = wayPointObject.GetComponent<WayPoint>();

        WayPoint selectedWayPoint = Selection.activeGameObject.GetComponent<WayPoint>();

        wayPointObject.transform.position = selectedWayPoint.transform.position;
        wayPointObject.transform.forward = selectedWayPoint.transform.forward;

        if(selectedWayPoint.previousWayPoint != null)
        {
            newWayPoint.previousWayPoint = selectedWayPoint.previousWayPoint;
            selectedWayPoint.previousWayPoint.nextWayPoint = newWayPoint;
        }

        newWayPoint.nextWayPoint = selectedWayPoint;

        selectedWayPoint.previousWayPoint = newWayPoint;

        newWayPoint.transform.SetSiblingIndex(selectedWayPoint.transform.GetSiblingIndex());

        Selection.activeGameObject = newWayPoint.gameObject;
    }

    void CreateWayPointAfter()
    {
        GameObject wayPointObject = new GameObject("WayPoint " + wayPointRoot.childCount, typeof(WayPoint));
        wayPointObject.transform.SetParent(wayPointRoot, false);

        WayPoint newWayPoint = wayPointObject.GetComponent<WayPoint>();

        WayPoint selectedWayPoint = Selection.activeGameObject.GetComponent<WayPoint>();

        wayPointObject.transform.position = selectedWayPoint.transform.position;
        wayPointObject.transform.forward = selectedWayPoint.transform.forward;

        newWayPoint.previousWayPoint = selectedWayPoint;

        if(selectedWayPoint.nextWayPoint != null)
        {
            selectedWayPoint.nextWayPoint.previousWayPoint = newWayPoint;
            newWayPoint.nextWayPoint = selectedWayPoint.nextWayPoint;
        }

        selectedWayPoint.nextWayPoint = newWayPoint;

        newWayPoint.transform.SetSiblingIndex(selectedWayPoint.transform.GetSiblingIndex());

        Selection.activeGameObject = newWayPoint.gameObject;

    }

    void RemoveWayPoint()
    {
        WayPoint selectedWayPoint = Selection.activeGameObject.GetComponent<WayPoint>();

        if(selectedWayPoint.nextWayPoint != null)
        {
            selectedWayPoint.nextWayPoint = selectedWayPoint.previousWayPoint;
        }

        if (selectedWayPoint.previousWayPoint != null)
        {
            selectedWayPoint.previousWayPoint.nextWayPoint = selectedWayPoint.nextWayPoint;
            Selection.activeGameObject = selectedWayPoint.previousWayPoint.gameObject;
        }

        DestroyImmediate(selectedWayPoint.gameObject);
    }
}
*/
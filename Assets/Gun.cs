using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    Ray ray;
    Touch touch;
    Vector3 direction;
    RaycastHit hit_info;
    RaycastHit turret_hit_info;
    Camera cam;
    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Vector3 mouseposFar = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.farClipPlane);
        Vector3 mouseposNear = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);

        Vector3 mouseposF = Camera.main.ScreenToWorldPoint(mouseposFar);
        Vector3 mouseposN = Camera.main.ScreenToWorldPoint(mouseposNear);

        Physics.Raycast(mouseposN, mouseposF - mouseposN, out hit_info);
        transform.LookAt(new Vector3(hit_info.point.x, 1, hit_info.point.z));
        if (Input.GetMouseButton(0))
        {
            Debug.DrawRay(mouseposN, mouseposF - mouseposN, Color.red);
            Debug.DrawRay(transform.position, transform.forward*1000, Color.blue);
            if (Physics.Raycast(transform.position, transform.forward * 100, out turret_hit_info, 100))
            {
                Debug.Log("hit " + turret_hit_info.collider.name);
            }
        }

    }

    
}

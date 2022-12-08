using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    float maxRotation = 100;
    float minRotation = 20;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePosition - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        if (angle < minRotation)
            angle = minRotation;
        if (angle > maxRotation)
            angle = maxRotation;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}

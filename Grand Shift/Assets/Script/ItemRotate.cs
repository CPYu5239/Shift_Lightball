using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotate : MonoBehaviour
{
    Transform originalPos;
    Transform cam;
    private void Start()
    {
        cam = GameObject.Find("Camera").GetComponent<Transform>();
        originalPos = transform;
    }

    private void Update()
    {
        print(originalPos.rotation);
        if (GameManager.is3D)
        {
            transform.rotation = cam.rotation;
        }
        else
        {
            transform.position = originalPos.position;
            transform.rotation = new Quaternion(0,0,0,1);
        }
    }
}

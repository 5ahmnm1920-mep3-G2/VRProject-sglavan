using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{


    public GameObject globe;

    void Update()
    {
        globe.transform.Rotate(Vector3.up * Time.deltaTime);
    }
}

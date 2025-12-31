 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBillboard : MonoBehaviour
{
    GameObject Camera;
    private void Start()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera"); 
    }
    private void Update()
    {
        transform.LookAt(Camera.transform,Vector3.up);
        transform.Rotate(0, 180, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCell2 : MonoBehaviour
{
    [SerializeField] float speed;

    // Update is called once per frame
    void Update()
    {
        RotateCell(speed);
    }
    public void RotateCell(float speedRotate)
    {
        this.gameObject.transform.Rotate(0, speedRotate * Time.deltaTime, 0);
    }
}

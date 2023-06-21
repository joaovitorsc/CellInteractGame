using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    [SerializeField]LineRenderer Line;
    [SerializeField]GameObject[] Points;



    private void Update()
    {
        LineRendeDraw();
    }
    void LineRendeDraw()
    {
        Line.SetPosition(0, Points[0].transform.position);
        Line.SetPosition(1, Points[1].transform.position);
    }
}

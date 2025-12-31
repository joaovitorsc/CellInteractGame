using System.Collections;
using UnityEngine;

public class LineController : MonoBehaviour
{
    [SerializeField] LineRenderer line;
    [SerializeField] GameObject[] points;

    private Coroutine drawCoroutine;
    private void OnEnable()
    {
        StopDrawing();
        drawCoroutine = StartCoroutine(LineRenderRoutine());
    }

    private void OnDisable()
    {
        StopDrawing();
    }

    private IEnumerator LineRenderRoutine()
    {
        var wait = new WaitForEndOfFrame();

        while (true)
        {
            if (line != null && points.Length >= 2)
            {
                line.SetPosition(0, points[0].transform.position);
                line.SetPosition(1, points[1].transform.position);
            }

            yield return wait;
        }
    }

    private void StopDrawing()
    {
        if (drawCoroutine != null)
        {
            StopCoroutine(drawCoroutine);
            drawCoroutine = null;
        }
    }
}

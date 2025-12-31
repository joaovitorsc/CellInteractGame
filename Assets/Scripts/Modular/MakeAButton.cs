using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class MakeAButton : MonoBehaviour
{
    public UnityEvent UnityEvent = new UnityEvent();
    [SerializeField] GameObject ButtonInteract, Line;
    public bool AbleInteract;
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject && AbleInteract)
            {
                UnityEvent.Invoke();
            }
        }
    }
    public void EnableandDisableGameObjects()
    {
        if (ButtonInteract.activeSelf == true && Line.activeSelf == true)
        {
            ButtonInteract.SetActive(false);
            Line.SetActive(false);
            
        }
        else
        {
            ButtonInteract.SetActive(true);
            Line.SetActive(true);
           
        }
    }
}

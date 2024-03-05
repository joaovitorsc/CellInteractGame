using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerButtons : MonoBehaviour
{
    [SerializeField] GameObject[] Buttons;
    [SerializeField] GameObject[] Lines;

    public void DisableotherObjects()
    {
        for (int i = 0; i < Buttons.Length; i++)
        {
            Buttons[i].SetActive(false);
        }

        for (int i = 0; i < Lines.Length; i++)
        {
            Lines[i].SetActive(false);
        }
    }
}

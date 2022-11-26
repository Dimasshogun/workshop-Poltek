using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelKuis1 : MonoBehaviour
{
    public GameObject PanelK1;
    public GameObject PanelK2;
    public GameObject PanelK3;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Kuis1"))
        {
            bool isActive = PanelK1.activeSelf;

            PanelK1.SetActive(!isActive);
        }
        if (collision.collider.CompareTag("Kuis2"))
        {
            bool isActive = PanelK2.activeSelf;

            PanelK2.SetActive(!isActive);
        }
        if (collision.collider.CompareTag("Kuis3"))
        {
            bool isActive = PanelK3.activeSelf;

            PanelK3.SetActive(!isActive);
        }
    }
}

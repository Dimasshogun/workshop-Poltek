using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ManagerBendaEmpat : MonoBehaviour
{
    public GameObject BendaSatu, BendaDua, BendaTiga, BendaEmpat, BendaSatuHitam, BendaDuaHitam, BendaTigaHitam, BendaEmpatHitam, finish;

    Vector2 BendaSatuInitialPos, BendaDuaInitialPos, BendaTigaInitialPos, BendaEmpatInitialPos;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;

    bool BendaSatuCorrect, BendaDuaCorrect, BendaTigaCorrect, BendaEmpatCorrect = false;
    // Start is called before the first frame update
    void Start()
    {
        BendaSatuInitialPos = BendaSatu.transform.position;
        BendaDuaInitialPos = BendaDua.transform.position;
        BendaTigaInitialPos = BendaTiga.transform.position;
        BendaEmpatInitialPos = BendaEmpat.transform.position;
    }

    
    // Update is called once per frame
    public void DragBendaSatu()
    {
        BendaSatu.transform.position = Input.mousePosition;
    }
    public void DragBendaDua()
    {
        BendaDua.transform.position = Input.mousePosition;
    }
    public void DragBendaTiga()
    {
        BendaTiga.transform.position = Input.mousePosition;
    }
    public void DragBendaEmpat()
    {
        BendaEmpat.transform.position = Input.mousePosition;
    }

    public void DropBendaSatu()
    {
        float Distance = Vector3.Distance(BendaSatu.transform.position, BendaSatuHitam.transform.position);
        if (Distance < 50)
        {
            BendaSatu.transform.position = BendaSatuHitam.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            BendaSatuCorrect = true;
        }
        else
        {
            BendaSatu.transform.position = BendaSatuInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void DropBendaDua()
    {
        float Distance = Vector3.Distance(BendaDua.transform.position, BendaDuaHitam.transform.position);
        if (Distance < 50)
        {
            BendaDua.transform.position = BendaDuaHitam.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            BendaDuaCorrect = true;
        }
        else
        {
            BendaDua.transform.position = BendaDuaInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void DropBendaTiga()
    {
        float Distance = Vector3.Distance(BendaTiga.transform.position, BendaTigaHitam.transform.position);
        if (Distance < 50)
        {
            BendaTiga.transform.position = BendaTigaHitam.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            BendaTigaCorrect = true;
        }
        else
        {
            BendaTiga.transform.position = BendaTigaInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void DropBendaEmpat()
    {
        float Distance = Vector3.Distance(BendaEmpat.transform.position, BendaEmpatHitam.transform.position);
        if (Distance < 50)
        {
            BendaEmpat.transform.position = BendaEmpatHitam.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            BendaEmpatCorrect = true;
        }
        else
        {
            BendaEmpat.transform.position = BendaEmpatInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    
    void Update()
    {
        if(BendaSatuCorrect && BendaDuaCorrect && BendaTigaCorrect && BendaEmpatCorrect)
        {
            finish.gameObject.SetActive(true);
        }
    }
}

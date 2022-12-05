using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    List<Transform> odalar = new List<Transform>();
    [SerializeField] private GameObject sopa;
    [SerializeField] private GameObject boosRoom;
    [SerializeField] private GameObject room;

    // Start is called before the first frame update
    void Start()
    {
        odaLateUpdate();
        RandomRoom();
        
    }

    private void odaLateUpdate()
    {
        GameObject gObj = GameObject.FindGameObjectWithTag("Odalar");
        foreach (Transform t in gObj.transform)
        {
            odalar.Add(t);
            print(t.name);
        }
    }
    private void RandomRoom()
    {
        boosRoom = odalar[Random.Range(0, odalar.Count)].gameObject;

        print(boosRoom.name);
        Koridor(sopa);
    }
    private void Koridor(GameObject go)
    {
        go.transform.LookAt(boosRoom.transform.position);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Odacık : MonoBehaviour
{
    [SerializeField] GameObject room;
    public bool action;
    
    void Start()
    {
        Spawn();
    }

    
    void Spawn()
    {
        Vector3 roomPos;
        roomPos = gameObject.transform.position;

        Instantiate(room, roomPos, Quaternion.identity);
        print(roomPos);
    }
}

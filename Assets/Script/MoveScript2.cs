using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript2 : MonoBehaviour
{
    public Transform EndPoint;

    void Start()
    {
        
    }

    
    void Update()
    {
        EndPoint.position = Vector3.MoveTowards(EndPoint.position, transform.position, Time.deltaTime);
    }
}

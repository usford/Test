using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Football : MonoBehaviour
{
    public Transform r2d2copy1;
    public Transform r2d2copy2;
    public Transform ball;
    void Start()
    {

        Vector3 r2d2pos = r2d2copy1.position;       
    }


    void Update()
    {
        Vector3 pos1copy1 = new Vector3(42.8F, 5.87F, -66.92F);
        Vector3 pos2copy1 = new Vector3(33.52F, 5.87F, -66.92F);

        r2d2copy1.position = Vector3.MoveTowards(r2d2copy1.position, pos1copy1, Time.deltaTime);

        if (r2d2copy1.position == pos1copy1)
        {

        }
    }
}

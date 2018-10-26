using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_3 : Enemy {
    //Enemy_3 will move following a Bezier curve, which is a linear interpolation between more than two points
    [Header("Set in Inspoector: Enemy_3")]
    public float lifeTime = 5;

    [Header("Set Dynamically: Enemy_3")]
    public Vector3[] points;
    public float birthTime;

    //Again, Start works well because it is not used by the Enemy superclass
    void Start()
    {
        points = new Vector3[3]; //Initialize points

        //The start position has already been set by Main.SpawnEnemy()
        points[0] = pos;

        //Set xMin and xMax the same way that Main.SpawnEnemy() does
        float xMin = -bndCheck.camWidth + bndCheck.radius;
        float Max = bndCheck.camWidth - bndCheck.radius;

        Vector3 v;
    }



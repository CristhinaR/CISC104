﻿using System;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
   public override void CollideWithBall(GameObject OtherBall)
   {
        Debug.Log("Green Ball Collision Manager Function");
        gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;


   }

    
}


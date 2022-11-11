using System;
using UnityEngine;

public class RedBallCollisionManager : BallCollisionManager
{
   public override void CollideWithBall(GameObject OtherBall)
   {
     Debug.Log("Red Ball Collision Manager Function");
        gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;




   }

  



}








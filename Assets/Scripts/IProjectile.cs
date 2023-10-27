using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IProjectile
{
   public float speed {get; set;}
   public float damage {get; set;}
   

   public void Move();
   public void Rotate();

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transforms;
    public vector2 offset;
    
    
    
    void LateUpdate()
    {
        transform.positon = player.positon + offset; 
    }
  
}

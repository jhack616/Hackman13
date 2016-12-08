//RandomRotator.cs
using UnityEngine;
using System.Collections;

public class BackgroundRotation : MonoBehaviour

{
	public float speed;
    void Update() 
    {
        // Rotate the object around its local X axis at 1 degree per second
        transform.Rotate(Vector3.up * speed);
    }
}
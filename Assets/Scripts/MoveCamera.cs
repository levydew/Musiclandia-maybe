using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
       transform.position = cameraPosition.position; 
    }

}

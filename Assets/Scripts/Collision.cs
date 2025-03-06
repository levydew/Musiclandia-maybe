using UnityEngine;

public class Collision : MonoBehaviour
{
    public int dam;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Monster"))
        {
            
        }
    }

}

using UnityEngine;

public class DealDamage : MonoBehaviour
{
    public PlayerHealth healthbarthing;
    public float damage1;

    private void OnTriggerEnter(Collider big)
    {
        //if (big.tag == "Player") 
        //{
		 // healthbarthing.TakeDamage(damage1);  
	    //}
        healthbarthing.TakeDamage(damage1);
    }
}

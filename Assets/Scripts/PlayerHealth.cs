using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
   public float health;
   public Slider healthbar;

   public void TakeDamage(float damage)
   {
         health -= damage;
         healthbar.value = health;
   }

   void update()
   {
      healthbar.value = health;
   }

}

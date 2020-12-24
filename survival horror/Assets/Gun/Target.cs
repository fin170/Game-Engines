
using UnityEngine;

public class Target : MonoBehaviour
{
    public float hp = 50f;
   public static int killcount;
    public float lifeTime = 60;
    public void TakeDamage (float amount)
    {
        hp -= amount;
        if(hp<=0)
        {
            Die();
        }

        lifeTime -= 1 * Time.deltaTime;
     if(lifeTime<0)
        {
            Enemyspawn.enCount--;
            Destroy(gameObject);
        }
    }

  void Die()
    {
        Enemyspawn.enCount--;
        killcount++;
        Destroy(gameObject);
    }
    
}

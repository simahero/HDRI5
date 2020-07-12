using UnityEngine;

public class CharacterStat : MonoBehaviour
{
    
    public float currentHealth;
    public Stat health;
    public Stat damage;
    public Stat armor;
    public Stat fireRate;
    public Stat movenentSpeed;
    public bool inv = false;

    void Start()
    {
        currentHealth = health.GetValue();
    }

    public void TakeDamage(float dmg){
        if (inv)
        {
            return;
        }
        else
        {
            dmg -= armor.GetValue();
            dmg = Mathf.Clamp(dmg, 0, float.MaxValue);
    	    currentHealth -= dmg;
        }
        if (currentHealth <= 0)
        {
            Die();
        }

    }

    public virtual void Die(){
        Destroy(gameObject);
    }

}

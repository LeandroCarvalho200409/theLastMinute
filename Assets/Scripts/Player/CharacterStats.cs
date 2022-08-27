using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public float current_Health;
    public float max_Health;
    public float current_Stamina;
    public float max_Stamina;
    public bool isDead = false;

    public void CheckHealth()
    {
        if(current_Health >= max_Health)
        {
            current_Health = max_Health;
        }

        if(current_Health <= 0)
        {
            current_Health = 0;
            isDead = true;
        }
    }

    public void CheckStamina()
    {
        if(current_Stamina >= max_Stamina)
        {
            current_Stamina = max_Stamina;
        }

        if(current_Stamina <= 0)
        {
            current_Stamina = 0;
        }
    }

    public virtual void Die()
    {
        //Override later
    }
    public void TakeDamage(float damage)
    {
        current_Health -= damage;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    public enemy enemy;
    public int damage;
    private void Start()
    {
        max_Health = 100;
        current_Health = max_Health;
        damage = 10;

        max_Stamina = 100;
        current_Stamina = max_Stamina;

        enemy = GameObject.Find("Character_anim_idle1").GetComponent<enemy>();
    }
    public void Update()
    {
        if(enemy.Enemyshooting == true)
        {
            current_Health = current_Health - 10;
        }
    }

}

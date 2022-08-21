using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkHoleBoss : MonoBehaviour
{
    public Boss bossScript;
    public int health; //this is the Variable for the health of the Enemys
    public int damage; //This is the Variable that making damage to the player
    private int gotDamage; //This is the Variable you need to call for damaging the enemy
    void Start()
    {
        health += bossScript.damageMaker(gotDamage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

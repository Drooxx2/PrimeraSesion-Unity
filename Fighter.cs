using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{
    public string Name, Category;
    public int Health;

    public bool IsAlive()
    {
        return Health > 0;
    }

    public void DecreaseHealth(int damage)
    {
        Health -= damage;
    }

}

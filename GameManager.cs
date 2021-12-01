using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Añadir los GameObjects en el editor
    public List<GameObject> fighters = new List<GameObject>();

    private List<string> names = new List<string>();
    private List<string> categories = new List<string>();
    private List<GameObject> deaths = new List<GameObject>();

    void Start()
    {
        //Se rellena la lista de nombres
        names.Add("Scorpion");
        names.Add("Kano");
        names.Add("Sonya");
        names.Add("Johnny Cage");
        names.Add("Sub-Zero");

        //Se rellena la lista de categorias
        categories.Add("Ninja");
        categories.Add("Mercenario");
        categories.Add("Teniente");
        categories.Add("Actor");
        categories.Add("Ninja");

        InitFighters();
    }

    private void InitFighters()
    {
        for(int i = 0; i < fighters.Count; i++)
        {
            Fighter _fighter = fighters[i].GetComponent<Fighter>();
            _fighter.Name = names[i];
            _fighter.Category = categories[i];
            _fighter.Health = Random.Range(80, 100);
        }
    }

    private GameObject HigherHealth()
    {
        int higherHealth = 0;
        GameObject fighter = null;

        foreach(GameObject element in fighters)
        {
            Fighter _fighter = element.GetComponent<Fighter>();

            if (_fighter.Health > higherHealth)
            {
                higherHealth = _fighter.Health;
                fighter = element;
            }
        }

        return fighter;
    }
}

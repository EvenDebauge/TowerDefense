
using UnityEngine;
using System.Collections.Generic;

public class TowerBase : MonoBehaviour
{
    public GameObject _upgrade = null;

    public GameObject upgrade { get { return _upgrade; } }

    private float fireRate { get; set; } = 0.1f;
    private float currentfireRate { get; set; } = 0.0f;

    private List<Ennemy> enemies { get; set; } = null;

  


    private void Start()
    {
        enemies = new List<Ennemy>();
    }


    private void Update()
    {

    }
      private void OnTriggerEnter(Collider other)
    {
        Ennemy enemy =  other.GetComponent<Ennemy>();
        if(enemy != null)
        {
            enemies.Add(enemy);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Ennemy enemy = other.GetComponent<Ennemy>();
        if (enemy != null)
        {
            enemies.Remove(enemy);
        }
    }

    public void Upgrade()
    {
        if (upgrade == null)
        {
            return;
        }

        Instantiate(upgrade, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
    
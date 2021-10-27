
using UnityEngine;
using System.Collections.Generic;

public class TowerBase : MonoBehaviour
{
    public GameObject _upgrade = null;

    public GameObject upgrade { get { return _upgrade; } }

    private float fireRate { get; set; } = 0.1f;
    private float currentfireRate { get; set; } = 0.0f;

    private bool canShoot { get; set; } = true;

    private List<Ennemy> enemies { get; set; } = null;

  


    private void Start()
    {
        enemies = new List<Ennemy>();
    }


    private void Update()
    {
        if(!canShoot)
        {
            currentfireRate += Time.deltaTime;
            if ( currentfireRate >= fireRate)
            {
                currentfireRate = 0;
                canShoot = true;
            }
            return;
        }
        if( enemies!= null && enemies.Count> 0)
        {
            Destroy(enemies[0].gameObject);
            enemies.RemoveAt(0);
            canShoot = false;
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

    public void AddEnemy(Ennemy enemy)
    {
        enemies.Add(enemy);

    }

    public void RemoveEnemy(Ennemy enemy)
    {
        enemies.Remove(enemy);
    }

}
    
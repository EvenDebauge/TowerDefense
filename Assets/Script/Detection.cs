
using UnityEngine;

public class Detection : MonoBehaviour
{

    private TowerBase towerparent { get; set; } = null;

    private void Start()
    {
        towerparent = GetComponentInParent<TowerBase>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Ennemy enemy = other.GetComponent<Ennemy>();
        if (enemy != null)
        {
            towerparent.AddEnemy(enemy);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Ennemy enemy = other.GetComponent<Ennemy>();
        if (enemy != null)
        {
            towerparent.RemoveEnemy(enemy);
        }
    }
}

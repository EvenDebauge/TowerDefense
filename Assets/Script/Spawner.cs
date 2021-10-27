using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwaner : MonoBehaviour
{ 

    public GameObject _enemyPrefab = null;

    private GameObject enemyPrefab { get { return _enemyPrefab; } }

    public float _spawnDelay = 0.5f;
    private float spawnDelay { get { return _spawnDelay; } }

    void Start()
    {
        InvokeRepeating("Spawn",0, spawnDelay);
    }
    private void Spawn()
    {
        Vector3 spawnPosition = transform.position;
        spawnPosition.z += Random.Range(-3.0f, 3.0f);
        Instantiate(enemyPrefab, spawnPosition, transform.rotation);
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
}

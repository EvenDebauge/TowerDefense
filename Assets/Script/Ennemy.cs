
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    private Transform enemyTransform { get; set; } = null;

    private float speed { get; set; } = 2.0f;


    private void Start()
    {
        enemyTransform = GetComponent<Transform>();
    }


    private void Update()
    {
        enemyTransform.position += Vector3.right * Time.deltaTime * speed;
    }
}

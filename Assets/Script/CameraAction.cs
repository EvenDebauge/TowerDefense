using UnityEngine;

public class CameraAction : MonoBehaviour
{

    private Transform cameraTransform { get; set; } = null;
    private void Start()
    {
        cameraTransform = GetComponent<Transform>();
    }

    void Update()
    {
        DrawRay();
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y,Camera.main.farClipPlane));

            Debug.DrawRay(cameraTransform.position, worldPos - cameraTransform.position, Color.red);

            if(Physics.Raycast(cameraTransform.position, worldPos - cameraTransform.position, out RaycastHit hit))
            {
                Debug.Log(hit.transform.name);
                TowerBase tower = hit.transform.GetComponent<TowerBase>();
                if(tower != null)
                {
                    tower.Upgrade();
                }
            }
        }
    }

    private void DrawRay()
    {
        Vector3 mousePosition = Input.mousePosition;

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, Camera.main.farClipPlane));

        Debug.DrawRay(cameraTransform.position, worldPos - cameraTransform.position, Color.red);
    }
}

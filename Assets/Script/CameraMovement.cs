using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform playerTransform;
    [SerializeField] private float cameraHeight;

    [SerializeField] private float mouseSensitivityX;
    [SerializeField] private float mouseSensitivityY;

    [SerializeField] private float minRotationX;
    [SerializeField] private float maxRotationX;


    // Start is called before the first frame update
    private void Start()
    {
        playerTransform = FindObjectOfType<PlayerMovement>().transform;
    }

    // Update is called once per frame
    private void Update()
    {
        SetPosition();
        SetRotation();
        SetPlayerRotation();
    }

    private void SetPosition()
    {
        Vector3 position = playerTransform.position;
        position.y += cameraHeight;
        transform.position = position;
    }
    private void SetRotation()
    {
        Vector3 rotation = transform.eulerAngles;

        rotation.y += Input.GetAxis("Mouse X") * (mouseSensitivityX * Time.deltaTime);
        rotation.x -= Input.GetAxis("Mouse Y") * (mouseSensitivityY * Time.deltaTime);

        rotation.x = Mathf.Clamp(minRotationX, rotation.x, maxRotationX);

        transform.eulerAngles = rotation;
    }

    private void SetPlayerRotation()
    {
        Vector3 rotation = playerTransform.eulerAngles;
        rotation.y = transform.eulerAngles.y;
        playerTransform.eulerAngles = rotation; 
    }
}

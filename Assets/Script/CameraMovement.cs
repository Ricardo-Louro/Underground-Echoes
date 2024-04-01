using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform playerTransform;
    [SerializeField] private float cameraHeight;

    [SerializeField] public float mouseSensitivity;

    [SerializeField] private float minRotationX;
    [SerializeField] private float maxRotationX;

    private Vector3 rotation;


    // Start is called before the first frame update
    private void Start()
    {
        playerTransform = FindObjectOfType<PlayerMovement>().transform;
        rotation = transform.eulerAngles;
    }

    private void OnEnable()
    {
        LockCursor();
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
        rotation.y += Input.GetAxis("Mouse X") * mouseSensitivity;
        rotation.x -= Input.GetAxis("Mouse Y") * mouseSensitivity;

        rotation.x = Mathf.Clamp(rotation.x, minRotationX, maxRotationX);

        transform.rotation = Quaternion.Euler(rotation);
    }

    private void SetPlayerRotation()
    {
        Vector3 rotation = playerTransform.eulerAngles;
        rotation.y = transform.eulerAngles.y;
        playerTransform.eulerAngles = rotation; 
    }

    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}

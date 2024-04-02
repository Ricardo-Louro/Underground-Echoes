using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCameraPath : MonoBehaviour
{
    [SerializeField] private Transform startPath;
    [SerializeField] private Transform endPath;
    [SerializeField] private float moveSpeed;

    // Update is called once per frame
    private void Update()
    {
        Vector3 pos = transform.position + transform.forward * (moveSpeed * Time.deltaTime);
        if (pos.z >= endPath.position.z)
        {
            pos = startPath.position;
        }
        transform.position = pos;
    }
}

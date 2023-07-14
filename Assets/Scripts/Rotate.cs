using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 axis;

    [SerializeField] private float rotateSpeed;

    private void Update()
    {
        transform.Rotate(axis,rotateSpeed);
    }
}

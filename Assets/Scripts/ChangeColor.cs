using UnityEngine;
using Random = UnityEngine.Random;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Material mat;

    private void Awake()
    {
        mat.color = Color.white;
    }

    private void OnMouseDown()
    {
        mat.color = Random.ColorHSV();
    }
}
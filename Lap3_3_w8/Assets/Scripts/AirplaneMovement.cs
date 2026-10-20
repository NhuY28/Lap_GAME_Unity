using UnityEngine;

public class AirplaneMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }
}
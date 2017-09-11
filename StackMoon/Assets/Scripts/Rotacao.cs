using UnityEngine;
public class Rotacao : MonoBehaviour
{
    public float volta = 50;
    void Update()
    {
        transform.Rotate(Vector3.up * volta * Time.deltaTime);
    }

}

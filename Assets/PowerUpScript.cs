using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2 (0f, -1f) * Time.deltaTime * speed);
    }
}

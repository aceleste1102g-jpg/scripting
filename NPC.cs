using UnityEngine;

public class he : MonoBehaviour
{
    // salud de NPC
    public int health = 5;

    // nivel de NPC 
    public int level = 1;
    
    // velocidad de NPC
    public float speed = 1.2f;
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // movimiento de jugador
    void Update()
    {
    Vector3 newPosition = transform.position;
    newPosition.z += speed * Time.deltaTime;
    transform.position = newPosition;
        
    }
}

using UnityEngine;

public class ForwardCarsMovement : MonoBehaviour
{
    public float speed = 15.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Making the obstacle cars to move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }
}

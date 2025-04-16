using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public GameObject self;
    public float speed;
    public float degrees;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.RotateAround(self.transform.position, Vector3.back, degrees * speed * Time.deltaTime);
  
    }
}

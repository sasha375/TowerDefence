using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Bullet b = null;
        collision.gameObject.TryGetComponent<Bullet>(out b);
        if (b != null)
        {
            Debug.Log("kill");
            Destroy(gameObject);
        }
    }
}

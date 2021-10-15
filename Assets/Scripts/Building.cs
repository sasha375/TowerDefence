using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    [SerializeField] private Vector2 _buildingSize;
    [SerializeField] private Renderer _renderer;
    public int _type;
    public GameObject resourseCounter;
    public GameObject bullet1;
    public float timer = 1;
    public float time;
    public bool _placed;

    public Vector2 BuildingSize { get => _buildingSize; set {; } }

    private void Start()
    {
        _placed = false;
        time = timer;
    }
    private void Update()
    {
        if (_placed)
        {
            if (_type == 0)
            {
                if (time < 0)
                {
                    resourseCounter.GetComponent<ResourceCounter>().ReceiveResources(1);
                    time = timer;
                }
            }
            if (_type == 1)
            {
                if (time < 0)
                {
                    Instantiate(bullet1, transform.position, Quaternion.identity);
                    time = timer;
                }
            }
            time -= Time.deltaTime;
        }
    }
    public void SetColor(bool isAvailableToBuild)
    {
        if (isAvailableToBuild)
            _renderer.material.color = Color.green;
        else
            _renderer.material.color = Color.red;
    }

    public void ResetColor()
    {
        _renderer.material.color = Color.white;
        _placed = true;
    }

    
}

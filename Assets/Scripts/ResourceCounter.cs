using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceCounter : MonoBehaviour
{
    [SerializeField] private int _resources;
    [SerializeField] private Text _resourcesText;
    private static ResourceCounter _instance;
    public static ResourceCounter Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    public void ReceiveResources(int res)
    {
        _resources += res;
        _resourcesText.text = _resources.ToString();
    }

}

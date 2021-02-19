using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBreaker : MonoBehaviour
{
    [SerializeField] private ObjectPool[] _objectPools;
    [SerializeField] private float _cameraOffsetX;

    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        foreach (var objectPool in _objectPools)
        {
            DisableObjectAbroadScreen(objectPool);
        }
    }

    private void DisableObjectAbroadScreen(ObjectPool objectPool)
    {
        Vector3 disablePoint = _camera.ViewportToWorldPoint(new Vector2(_cameraOffsetX, 0));
        foreach (Template item in objectPool.Pool)
        {
            if (item.gameObject.activeSelf == true)
            {
                if (item.transform.position.x < disablePoint.x)
                    item.gameObject.SetActive(false);
            }
        }
    }
}

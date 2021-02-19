using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private Template _template;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private ObjectPool _objectPool;

    private void Start()
    {
        _objectPool.Initialize(_template);
    }

    private void Update()
    {
        TryGetObject();
    }

    private void TryGetObject()
    {
        if (_objectPool.TryGetObject(out Template template))
        {
            MoveItem(template);
        }
    }

    private void MoveItem(Template item)
    {
        item.transform.position = _spawnPoint.position;
        item.gameObject.SetActive(true);
        _spawnPoint.position += new Vector3(item.OffsetX, 0, 0);
    }
}

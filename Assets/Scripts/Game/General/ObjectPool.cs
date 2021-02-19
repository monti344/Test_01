using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private int _capacity;

    private List<Template> _pool = new List<Template>();

    public List<Template> Pool => _pool;

    public void Initialize(Template prefab)
    {
        for (int i = 0; i < _capacity; i++)
        {
            Template spawned = Instantiate(prefab, transform);
            spawned.gameObject.SetActive(false);
            _pool.Add(spawned);
        }
    }

    public bool TryGetObject(out Template result)
    {
        result = _pool.FirstOrDefault(p => p.gameObject.activeSelf == false);
        return result != null;
    }
}

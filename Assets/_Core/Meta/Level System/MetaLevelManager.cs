using System.Collections.Generic;
using UnityEngine;

public class MetaLevelManager : MonoBehaviour
{
    public List<MetaLevel> levels = new List<MetaLevel>();
    public int currentLevelId = 0;
    public static MetaLevelManager Instance { get; private set; }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public MetaLevel GetLevelById(int id)
    {
        if (levels.Count >= id && id >= 0)
        {
            return levels[id];
        }
        Debug.LogError("Levels list is empty!");
        return null;

    }
}

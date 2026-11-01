using UnityEngine;

public class GameSession : MonoBehaviour
{
    void Awake()
    {
        int numberOfGameSessions = FindObjectsByType<GameSession>(FindObjectsInactive.Include).Length;
        if (numberOfGameSessions > 1 )
        {
            Destroy(gameObject);
        }

        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

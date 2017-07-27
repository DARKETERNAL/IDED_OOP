using UnityEngine;

// Event creation for public access
public delegate void CollisionDetected();

[RequireComponent(typeof(Collider))]
public class GameEventManager : MonoBehaviour
{
    public event CollisionDetected onCollisionDetected;

    private static GameEventManager instance;

    public static GameEventManager Instance
    {
        get
        {
            return instance;
        }

        set
        {
            instance = value;
        }
    }

    // Use this for initialization
    private void Awake()
    {
        instance = this;
    }

    private void OnDestroy()
    {
        onCollisionDetected = null;
        instance = null;
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider != null && onCollisionDetected != null)
        {
            onCollisionDetected();
        }
    }
}
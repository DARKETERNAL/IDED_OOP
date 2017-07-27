using UnityEngine;

public delegate void OnDistanceMoved();

public class GameDelegateManager : MonoBehaviour
{
    private static GameDelegateManager instance;

    public event OnDistanceMoved onDistanceMoved;

    [SerializeField]
    private float movementLimit = 50F;

    private float totalDistanceMoved = 0F;
    private float prevXPos = 0F;

    public static GameDelegateManager Instance
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
        onDistanceMoved = null;
        instance = null;
    }

    // Update is called once per frame
    private void Update()
    {
        float currentXPos = transform.position.x;
        float deltaMove = Mathf.Abs(currentXPos - prevXPos);
        if (deltaMove > 0F)
        {
            totalDistanceMoved += deltaMove;

            if (totalDistanceMoved >= movementLimit && onDistanceMoved != null)
            {
                onDistanceMoved();
            }
        }
    }
}
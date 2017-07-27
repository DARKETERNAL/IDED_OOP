using UnityEngine;

public class DelegateCaller : MonoBehaviour
{
    private OnDistanceMoved onDistanceMoved;

    public void CallDelegateFromManager()
    {
        
    }

    public void CallDelegate()
    {
        onDistanceMoved();
    }

    private void Start()
    {
        onDistanceMoved = new OnDistanceMoved(CallDelegateFromManager);
    }
}
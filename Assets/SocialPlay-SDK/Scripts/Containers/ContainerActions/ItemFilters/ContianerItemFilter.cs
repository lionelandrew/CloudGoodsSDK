using UnityEngine;
using System.Collections;

public abstract class ContianerItemFilter : MonoBehaviour
{
    public enum InvertedState
    {
        required, excluded
    }
    public InvertedState type;

    public abstract bool CheckFilter(ItemData item);
}

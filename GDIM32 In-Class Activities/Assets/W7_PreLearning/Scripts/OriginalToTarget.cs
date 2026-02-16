using UnityEngine;

public class OriginalToTarget : MonoBehaviour
{
    [SerializeField] private Transform _original;
    [SerializeField] private Transform _target;

    private void Start ()
    {
        Vector3 displacementToTarget = _target.position - _original.position;
        _original.position += displacementToTarget;

        Debug.Log(new Vector3(-2, 3, 0) + new Vector3(-1, -4, 0));
    }
}
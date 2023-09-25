using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentPlayer : MonoBehaviour
{
    [SerializeField] private Transform _pointA;
    [SerializeField] private Transform _pointB;

    private NavMeshAgent _navMeshAgentPlayer;
    private Vector3 _currentPosition;

    private void Awake()
    {
        _navMeshAgentPlayer = GetComponent<NavMeshAgent>();   
    }

    private void Start()
    {
        _currentPosition = _pointA.position;
        _navMeshAgentPlayer.SetDestination(_currentPosition);
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, _currentPosition) > 1)
        {
            return;
        }

        if (_currentPosition == _pointA.position)
        {
            _currentPosition = _pointB.position;
        }
        else 
        {
            _currentPosition = _pointA.position;
        }

        _navMeshAgentPlayer.SetDestination(_currentPosition);
    }
}

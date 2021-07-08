using UnityEngine;
using UnityEngine.AI;

public class AIRoot : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Animator animator;

    private Vector3 worldDeltaPosition;
    private Vector3 position;

    public Transform target;

    private void Start()
    {
        worldDeltaPosition = Vector3.zero;
        position = Vector3.zero;

        agent.updatePosition = false;
    }

    private void Update()
    {
        worldDeltaPosition = agent.nextPosition - transform.position;

        if (worldDeltaPosition.magnitude > agent.radius)
        {
            agent.nextPosition = transform.position + 0.9f * worldDeltaPosition;
            agent.SetDestination(target.position);

        }
        
    }

    private void OnAnimatorMove()
    {
        position = animator.rootPosition;
        position.y = agent.nextPosition.y;
        transform.position = position;
    }
}

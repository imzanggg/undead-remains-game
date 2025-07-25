using UnityEngine;
using UnityEngine.AI;

public class CommonInfectedAI : MonoBehaviour
{
    public enum State { Idle, Chase, Attack, Patrol}
    public State currentState = State.Idle;
    public Transform[] patrolPoints;
    private int currentPatrolIndex = 0;
    private float detectionRange = 10f;
    private float attackRange = 2f;
    private float attackCooldown = 2f;
    private float lastAttackTime;

    private Transform player;
    private NavMeshAgent agent;
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player")?.transform;

        if (patrolPoints.Length > 0 )
        {
            currentState = State.Patrol;
            agent.SetDestination(patrolPoints[currentPatrolIndex].position);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case State.Patrol:
                patrolPoints()
        }

        void Patrol ()
        {
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            {
                currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
                agent.SetDestination(patrolPoints[currentPatrolIndex].position);
            }
        }
    }
}

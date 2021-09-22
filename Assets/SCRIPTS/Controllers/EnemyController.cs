using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    public Transform firepoint;
    public GameObject prefab;
    public float bulletforce = 20f;
    public float fr = 1;
    private float nextFire = 0f;

    public float lookRadius = 10f;
    Transform target;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = PlayerLoader.instance.player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);

            if (distance <= agent.stoppingDistance)
            {
                FaceTarget();
                Shoot();
            }
        }

    }

    void Shoot(){
    	GameObject bullet = Instantiate(prefab, firepoint.position, firepoint.rotation);
        bullet.GetComponent<Bullet>().setOwner(firepoint.root.gameObject);
    	Rigidbody rb = bullet.GetComponent<Rigidbody>();
    	rb.AddForce(firepoint.forward * bulletforce, ForceMode.Impulse);
    }

    void FaceTarget(){
        Vector3 dir = (target.position - transform.position).normalized;
        Quaternion lookRot = Quaternion.LookRotation(new Vector3(dir.x, 0, dir.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, 5f * Time.deltaTime);
        firepoint.transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, 5f * Time.deltaTime);
    }

    void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}

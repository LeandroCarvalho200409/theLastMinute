using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    private Rigidbody bulletrb;
    public float speed;
    public enemy enemy;
    public Transform enemytrans;
    public Vector3 enemyvector3;
    public float timeleft = 0f;
    public Playermovementcontroler pm;

    public void Start()
    {
        enemy = GameObject.Find("Character_anim_idle1").GetComponent<enemy>();
        bulletrb = gameObject.GetComponent<Rigidbody>();
        pm = GameObject.Find("Player").GetComponent<Playermovementcontroler>();
    }

    public void Seek(Transform _target)
    {
        target = _target;
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            Debug.Log("No Target");
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;


        if(dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        if (bulletrb == null)
        {
            bulletrb = gameObject.GetComponent<Rigidbody>();
        }

        bulletrb.AddForce(dir*100);



    }

    void HitTarget()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
            Debug.Log("Player was hit");
            if(pm == null)
            {
                pm = GameObject.Find("Player").GetComponent<Playermovementcontroler>();
            }
        }
            pm.RemHealth();

        
    }
}

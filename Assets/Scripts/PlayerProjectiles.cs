using UnityEngine;

public class PlayerProjectiles : MonoBehaviour
{
    [Header("Where to Fire From?")]
    [SerializeField]
    private Transform projectileTransform;
    public bool canFire;
    private Animator anim;

    [SerializeField]
    private GameObject projectile;

    private PlayerController player;

    // Use this for initialization
    private void Start()
    {
        anim = GetComponent<Animator>();
        player = GetComponentInParent<PlayerController>();
    }

    // Update is called once per frame
    private void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger("Firing");
            Instantiate(projectile, projectileTransform.position, projectileTransform.rotation);
        }
    }
}
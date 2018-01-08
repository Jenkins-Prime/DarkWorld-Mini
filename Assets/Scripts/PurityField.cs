using UnityEngine;

public class PurityField : MonoBehaviour
{
    [SerializeField]
    private float growthRate;
    [SerializeField]
    private float maxScaleXY;
    private CircleCollider2D coll;
    private bool active;
    private float t;
    // Use this for initialization
    private void Start()
    {
        coll = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    private void Update()
    {
			if (t <= 1) {
				t += growthRate * Time.deltaTime;
				var scale = transform.localScale;
				float newScale = Mathf.Lerp (0, maxScaleXY, t);
				scale.x = scale.y = newScale;
				transform.localScale = scale;
			}
		

    }

    private void OnEnable()
    {
        active = true;
    }


}
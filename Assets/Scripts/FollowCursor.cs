using UnityEngine;

public class FollowCursor : MonoBehaviour {

    private Transform _cursorTransform;
    private Animator _animator;

    public float speed = 100f;

	void Awake ()
    {
        _cursorTransform = GameObject.FindGameObjectWithTag("Cursor").transform;
        _animator = GetComponent<Animator>();
    }
	
	void Update ()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, _cursorTransform.position, step);
        transform.rotation = Quaternion.FromToRotation(Vector3.forward, _cursorTransform.position);

        bool isWalking = transform.position != _cursorTransform.position;
        _animator.SetBool("IsWalking", isWalking);
	}
}

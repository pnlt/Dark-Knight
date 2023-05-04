using UnityEngine;

public class CameraFollowObject : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform _playerTransform;

    [Header("Flip Rotation Stats")]
    [SerializeField] private float _flipYRotationTime = 0.5f;

    private Coroutine _turnCoroutine;

    private playerMovement _player;

    private bool _isFacingRight;

  private void Awake() {
    _player = _playerTransform.gameObject.GetComponent<playerMovement>();

    // _isFacingRight = _player.moveInput;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

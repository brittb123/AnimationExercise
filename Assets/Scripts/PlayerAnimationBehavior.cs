using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationBehavior : MonoBehaviour
{
    private PlayerMovementBehaviour _playerMovement;

    [SerializeField]
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        _playerMovement = GetComponent<PlayerMovementBehaviour>();
    }

    public void ActivateWinTrigger()
    {
        animator.SetTrigger("WinGame");
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", _playerMovement.Velocity.magnitude);
        animator.SetBool("InAir", !_playerMovement.IsGrounded);
    }
}

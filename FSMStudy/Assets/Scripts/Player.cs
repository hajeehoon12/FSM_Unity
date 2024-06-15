using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [field : Header("Animations")]
    [field : SerializeField] public PlayerAnimationData AnimationData { get; private set; }

    public Animator animator { get; private set; }
    public PlayerController Input { get; private set; }
    public CharacterController Controller { get; private set; }


    private void Awake()
    {
        AnimationData.Initalize();
        animator = GetComponent<Animator>();
        Input = GetComponent<PlayerController>();
        Controller = GetComponent<CharacterController>();
    }


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }


    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
    [SerializeField] RuntimeAnimatorController charAnimReference;
    [SerializeField] CharacterAnimController charAnimController;

    // Start is called before the first frame update
    void Start()
    {
        InitComponents();
    }



    void InitComponents() {
        RuntimeAnimatorController charAnimator = Instantiate<RuntimeAnimatorController>(charAnimReference);
        charAnimator.name = "Anim_" + gameObject.name;
        charAnimController.animator.runtimeAnimatorController = charAnimator;
    }
}

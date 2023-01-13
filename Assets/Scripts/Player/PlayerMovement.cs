using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float x = -1;

    void Update()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            x += Input.GetAxisRaw("Horizontal") > 0 ? 1 : -1;
            x = Mathf.Clamp(x, -1, 1);

            LeanTween.cancel(gameObject);

            LeanTween.moveLocalX(gameObject, x, 0.75f).setEase(LeanTweenType.easeOutExpo);

            LeanTween.rotateZ(gameObject, Input.GetAxisRaw("Horizontal") * -15f, 0.25f).setEase(LeanTweenType.easeOutQuad).setOnComplete(() =>
             LeanTween.rotateZ(gameObject, 0, 0.45f).setEase(LeanTweenType.easeOutBack)
            );
        }
    }
}

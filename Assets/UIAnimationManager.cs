using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements.Experimental;

public class UIAnimationManager : MonoBehaviour
{
    public GameObject button;
    public Vector3 shrinkSize,enlargeSize;
    public float animationDuration;
    public Vector3 finalPosition;
    public Vector3 initialPosition;
    public Ease easing;
    public GameObject Image;

    public void ShrinkUI()
    {
        button.transform.DOScale(shrinkSize, animationDuration).OnComplete(() => button.transform.DOScale(Vector3.one,animationDuration));
    }
    public void EnlargeUI()
    {
        button.transform.DOScale(enlargeSize, animationDuration);
    }
    public void MoveButton()
    {
        button.transform.DOLocalMove(finalPosition,animationDuration).SetEase(easing).OnComplete(()=>EnlargeUI());
    }
    public void ReversePositionButton()
    {
        button.transform.DOLocalMove(initialPosition, animationDuration).SetEase(easing).OnComplete(() => MoveButton());
    }
    public void ShakeButton()
    {
        //float duration,strength = 1min, vibrato, 
        button.transform.DOShakePosition(5, 1000, 10, 90);
        button.transform.DOShakeScale(5, 1000, 10, 90);
    }
    public void FadeButton()
    {
        Image colorButton;
        colorButton = button.GetComponent<Image>();
        colorButton.DOFade();
    }
    public void RotateButton()
    {

    }
}

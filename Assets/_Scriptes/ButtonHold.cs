using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ButtonHold : MonoBehaviour ,IPointerDownHandler,IPointerUpHandler
{
    public float holdTime;
    public UnityEvent unityEvent;
    [SerializeField] private CarMove _carMove;
    [SerializeField] private Wheel _carWheel;
    public bool _pointerDown;
    private float _pointerDownTimer;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        _pointerDown = true;

        //start game running
        //GameManager.IsGameRunning = true;

        Debug.Log("is Pointer Down");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        reset();
        Debug.Log("is Pointer Up");
    }

    private void FixedUpdate()
    {
        if (_pointerDown)
        {
            //_pointerDownTimer += Time.deltaTime;

            //increase car move speed
            //_carMove.rd.AddForce(Vector2.right * 50f,ForceMode2D.Force);
            _carWheel.wheelRotationSpeed += 0.5f;
            _carWheel.rd.angularVelocity = _carWheel.wheelRotationSpeed * -100;
                
            //if (_pointerDownTimer >= holdTime)
            //{
            //    Debug.Log("reset now");

            //    if (unityEvent != null)
            //    {
            //        unityEvent.Invoke();
            //    }



            //    reset();
            //}
        }
        else
        {
            // _carMove.rd.AddForce(Vector2.left * 5f);
            //_carWheel.rd.angularVelocity = _carWheel.wheelRotationSpeed * 10;
            if (_carWheel.wheelRotationSpeed<=0)
            {
                _carWheel.wheelRotationSpeed= 0;
                _carWheel.rd.angularVelocity = 0f;
            }
            else
            {
                _carWheel.wheelRotationSpeed -= 0.5f;
            }            
        }
    }

    private void reset()
    {

        Debug.Log("is reset called");

        _pointerDown = false;
        _pointerDownTimer = 0f;

        //game running stop
        GameManager.IsGameRunning = false;

        // reset force
        //_carMove.rd.AddForce(Vector2.left * Time.deltaTime);
    }
}

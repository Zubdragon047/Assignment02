using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputHandler : MonoBehaviour
{
   public Camera mainCam;
   public colorChanger colorChanger;
   public DataLogger dataLogger;
   private void Start()
   {
        mainCam = Camera.main;
   }
   public void Update()
   {
     dataLogger.time += Time.deltaTime;
   }
   public void OnClick(InputAction.CallbackContext context)
   {
        if(!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(mainCam.ScreenPointToRay(Mouse.current.position.ReadValue()));

        if(!rayHit.collider){
          return;
        } else {
          dataLogger.finalTime = dataLogger.time;
          dataLogger.time = 0;
          // colorChanger.changeColor(rayHit.collider.gameObject);
          // colorChanger.colorNextCircle(rayHit.collider.gameObject.name);
          if(rayHit.collider.gameObject.name == "background")
          {
            dataLogger.wrong = 1;
            dataLogger.WriteCSV();
          }else{
            colorChanger.changeColor(rayHit.collider.gameObject);
            colorChanger.colorNextCircle(rayHit.collider.gameObject.name);
          }
        }
   }
}

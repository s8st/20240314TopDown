# 20240314TopDown

---  

> # 20240314


```mermaid
%% TD : topdown, LR : left right%%
graph LR;  
    PlayerInputController.cs==>TopDownMovement.cs;
    PlayerInputController.cs-->TopDownCharacterController.cs;
TopDownCharacterController.cs-->TopDownAimRotation.cs 
    TopDownCharacterController.cs-->TopDownMovement.cs;
```

PlayerInputController.cs  
TopDownMovement.cs  
TopDownCharacterController.cs  
TopDownAimRotation.cs  


---
![image](https://github.com/s8st/20240314TopDown/assets/153998744/d1c49d86-8d46-4856-986c-2b41c00af3dd)  

Look에 mousePosition추가해야 `TopDownAimRotation.cs`에서 ` public void OnAim(Vector2 newAimDirection)
 {
     RotateArm(newAimDirection);
 }` 작동

---

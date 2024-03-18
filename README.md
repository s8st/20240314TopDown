# 20240314TopDown

---
#0318





[![](https://github.com/s8st/20240314TopDown/assets/153998744/de0d4e58-1b5d-4b50-9a32-24ff8faedf0b)](https://s8st.github.io/20240314TopDown/)  

```
[![](그림이미지 주소)](링크 연결 주소)
[![](https://github.com/s8st/20240314TopDown/assets/153998744/de0d4e58-1b5d-4b50-9a32-24ff8faedf0b)](https://s8st.github.io/20240314TopDown/)
```




https://github.com/s8st/20240314TopDown/assets/153998744/cde06944-5505-49d6-b277-461ea2101a51



---
> # 20240314


```mermaid
%% TD : topdown, LR : left right%%
graph LR;  
    PlayerInputController.cs==>TopDownMovement.cs  
    PlayerInputController.cs-->TopDownCharacterController.cs  
TopDownCharacterController.cs-..->TopDownAimRotation.cs   
    TopDownCharacterController.cs-->TopDownMovement.cs  
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

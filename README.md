# 20240314TopDown
---


#0319  

- 조이스틱 달기 --> 모바일에서 사용할 수 있게
- https://www.youtube.com/watch?v=O5Qvq4dypOg&list=PLO-mt5Iu5TeZF8xMHqtT_DhAPKmjF6i3x&index=22
- 스크립트 목록 정리하기
- 폴더에 넣고 연결하기
- 클래스 다이어그램 만들어 보기




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

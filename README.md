# 20240314TopDown
---


#0319  

- 조이스틱 달기 --> 모바일에서 사용할 수 있게
- https://www.youtube.com/watch?v=O5Qvq4dypOg&list=PLO-mt5Iu5TeZF8xMHqtT_DhAPKmjF6i3x&index=22
- 스크립트 목록 정리하기
- 폴더에 넣고 연결하기
- 클래스 다이어그램 만들어 보기

`깃허브 프로젝트 만들기 찾아보기`  

깃허브 헙업, 프로젝트 만들기 : 
https://www.youtube.com/watch?v=6sBNPvxjyt0  




---  


 //힐을 더 회복하게 만들어 준다
PickupHeal : PickupItem   
         _healthSystem = receiver.GetComponent<HealthSystem>();
        _healthSystem.ChangeHealth(healValue);
    

// OnPickedUp구현하고 아이템을 먹으면 stat에 설정된 만큼 추가
PickupStatModifiers : PickupItem
{
    [SerializeField] private List<CharacterStats> statsModifier;
    protected override void OnPickedUp(GameObject receiver)
    {
        CharacterStatsHandler statsHandler = receiver.GetComponent<CharacterStatsHandler>();
        foreach (CharacterStats stat in statsModifier)
        {
            statsHandler.AddStatModifier(stat);
     

// 먹을 수 있는 아이템인지 검사, 집으면 삭제하고 소리나게 하고 파괴
public abstract class PickupItem : MonoBehaviour
 
    protected abstract void OnPickedUp(GameObject receiver);




// 소리 등록하고 재생하고 끄기
public class SoundSource : MonoBehaviour

       public void Play(AudioClip clip, float soundEffectVolume, float soundEffectPitchVariance)
   


// 배경음악 재생, 오브젝트풀로 만들기
public class SoundManager : MonoBehaviour
   
        ChangeBackGroundMusic(musicClip);
         public static void PlayClip(AudioClip clip)
   


// 걸을 때 에니메이션 이벤트에 연결하기, 발바닥에 먼지 파티클 효과
public class DustParticleControl : MonoBehaviour

    public void CreateDustParticles()





// 죽으면 벡터 제로, 투명도를 30%, 2초후 삭제
public class DisappearOnDeath : MonoBehaviour

    void OnDeath()
    




//  데미지 받을때 오디오클립 재생, 힐 받으면 체력 증가, 데미지 받으면 체력 감소,체력 0이면 OnDeath
public class HealthSystem : MonoBehaviour

    public bool ChangeHealth(float change)
        private void CallDeath()
  






// 원거리 공격 몬스터의 공격 판단 
public class TopDownRangeEnemyContreoller : TopDownEnemyController

    protected override void FixedUpdate()







// 근접 몬스터 공격 판단, 공격받으면 추격거리를 100으로 확장, 공격할 때 넉백 적용
public class TopDownContactEnemyController : TopDownEnemyController

    private void OnDamage()
  

    protected override void FixedUpdate()
 

    private void Rotate(Vector2 direction)
   

    private void OnTriggerEnter2D(Collider2D collision)
      
    // 충돌 여부 체크
    private void OnTriggerExit2D(Collider2D collision)
   
    // 넉백 적용	
    private void ApplyHealthChange()
   






// 코루틴으로  몬스터 발생시키기, 웨이브 증가, 몬스터 랜덤 업그레이드, 아이템 보상 생성
// 체력UI,게임오버,업데이트웨이브UI,다시시작하기,게임 나가기
public class GameManager : MonoBehaviour

       UpgradeStatInit();
       StartCoroutine("StartNextWave"); 
        
    IEnumerator StartNextWave()
   
    private void OnEnemyDeath()
   
    private void UpdateHealthUI()
    

    private void GameOver()
  
    private void UpdateWaveUI()
   
    public void RestartGame()
  
    public void ExitGame()
   
    void CreateReward()
 
    //스탯 초기화
    void UpgradeStatInit()
  
    void RandomUpgrade()
   
        





// 거리와 방향 게산
public class TopDownEnemyController : TopDownCharacterController
   
    protected float DistanceToTarget()
     protected Vector2 DirectionToTarget()
  




// 애니메이션 설정 : 걷기,공격,피격 시 에니메이터의 값 조정
public class TopDownAnimationController : TopDownAnimations

    private void Move(Vector2 obj)
   
    private void Attacking(AttackSO obj)
    
    private void Hit()
  

    private void InvincibilityEnd()
 



// TopDownAnimationController 에서 상속받아서 사용
public class TopDownAnimations : MonoBehaviour

         animator = GetComponentInChildren<Animator>();
        controller = GetComponent<TopDownCharacterController>();
    



// 구조체 Pool의 필드를 가지는 Dictionary<string, Queue<GameObject>>를 계속 생성시키기
public class ObjectPool : MonoBehaviour
{
   
    public struct Pool
 
    public GameObject SpawnFromPool(string tag)
  















































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

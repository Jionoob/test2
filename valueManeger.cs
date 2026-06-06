using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class valueManeger : MonoBehaviour
{
    public static valueManeger instance;
    //[공용] [고정] [클래스 이름] [파괴여부] 
    public int flower_group;
    //0,1,2,3 씨앗, 새싹, 꽃봉오리, 만개한 꽃 
    public int nowClikPoint;
    // 점점 증가시키기
    public int mony;
    // 현재 포인트
    public int now_tool; 
    // 0,1,2,3 하급,중급,상급,황금 물뿌리게
    public int[] now_tool_power = {10,20,40,80}; 
    void Start(){
        now_tool = 0;
        flower_group = 0;
        mony = 0;
    }
    void Awake()
    {
        if (instance != null)          // 이미 존재하면
        {
            Destroy(gameObject);       // 중복 제거 
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject); // 씬 전환해도 살아남음
    }


}

using UnityEngine;
using UnityEngine.UI;  // 추가!
using TMPro;
using System.Collections;

public class PlantManager : MonoBehaviour
{
    public Image plants_Image;       // 이걸로 교체
    public Image EXPbar_now;  // EXPbar의 제어용 변수 선언
    public Sprite[] plantStages;   // 4단계 이미지    
    // plantStages[0]~~plantStages[3]
    public TMP_Text expText;  // 경험치 수치 표시기의 제어용 변수 선언
    public TMP_Text coinText;  // 돈표시
    private float[] maxPoint = {100f,200f,400f,800f};

    void Start()
    {
        EXPbar_now.fillAmount = 0f;
    }
    public void OnClickGrow()
    {
        valueManeger.instance.nowClikPoint += valueManeger.instance.now_tool_power[valueManeger.instance.now_tool];
        //지금 값을 갱신하고자함.
        UpdateSprite();
        UpdateEXPBar(); 
    }
    void UpdateEXPBar()
    {
        expText.text = valueManeger.instance.nowClikPoint.ToString();
        //텍스트 수치 변화
        EXPbar_now.fillAmount = valueManeger.instance.nowClikPoint / maxPoint[valueManeger.instance.flower_group];
        //EXPbar_now.fillAmount 해당 이미지 파일의 채우기 옴셥을 어떻게 할것인가?
        if(EXPbar_now.fillAmount % 10 == 0f)
        {
            valueManeger.instance.mony += Random.Range(10, 21);
            coinText.text = valueManeger.instance.mony.ToString();
        }
    }
    void UpdateSprite()
    {
        if (valueManeger.instance.nowClikPoint >= maxPoint[valueManeger.instance.flower_group]){
            StopCoroutine(FadeIn());   // 혹시 실행중이면 중단
            plants_Image.fillAmount = 0;
            valueManeger.instance.flower_group++;
            plants_Image.sprite = plantStages[valueManeger.instance.flower_group];
            valueManeger.instance.nowClikPoint = 0; 
            StartCoroutine(FadeIn());
        }
    }

    IEnumerator FadeIn()
    {   
        for(float i = 0f ; i<=1f ; i= i+0.001f){
            plants_Image.fillAmount += i;
            yield return new WaitForSeconds(0.05f);
        }
    }
}
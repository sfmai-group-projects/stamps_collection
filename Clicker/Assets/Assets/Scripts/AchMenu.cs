using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchMenu : MonoBehaviour
{
    public int score;
    public int total_score;
    [SerializeField] bool isFirst;


    public string[] arrayTitles;
    public Sprite[] arraySprites;
    public GameObject button;
    public GameObject content;

    private List<GameObject> list = new List<GameObject>();
    private VerticalLayoutGroup _group;

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("money");
        total_score = PlayerPrefs.GetInt("total_score");
        isFirst = PlayerPrefs.GetInt("isFirst") == 1 ? true : false;

        RectTransform rectT = content.GetComponent<RectTransform>();
        rectT.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
        _group = GetComponent<VerticalLayoutGroup>();
        setAchievs();
    }

    private void Removedlist()
    {
        foreach (var elem in list)
        {
            Destroy(elem);
        }
        list.Clear();
    }

    void setAchievs()
    {
        RectTransform rectT = content.GetComponent<RectTransform>();
        rectT.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
        Removedlist();
        if (arrayTitles.Length > 0)
        {
            var pr1 = Instantiate(button, transform);
            var h = pr1.GetComponent<RectTransform>().rect.height;
            var tr = GetComponent<RectTransform>();
            tr.sizeDelta = new Vector2(tr.rect.width, h *
            arrayTitles.Length);
            Destroy(pr1);
            for (var i = 0; i < arrayTitles.Length; i++)
            {
                var pr = Instantiate(button, transform);
                pr.GetComponentInChildren<Text>().text = arrayTitles[i];
                pr.GetComponentsInChildren <Image>()[1].sprite = arraySprites[i];
                var i1 = i;
                pr.GetComponent<Button>().onClick.AddListener(() => GetAchievement(i1));
                list.Add(pr);
            }
        }
    }

    void GetAchievement(int id)
    {
        switch (id)
        {
            case 0:
                Debug.Log(id);
            break;

            case 1:
                Debug.Log(id);
                score += 10;
                PlayerPrefs.SetInt("score", score);
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

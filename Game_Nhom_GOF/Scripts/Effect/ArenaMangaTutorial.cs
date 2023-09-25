using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ArenaMangaTutorial : MonoBehaviour
{
    [SerializeField]
    //the model of our world
    private List<ArenaBlock> arenaBlocks;

    public GameObject arenaBlockPrefab;

    [SerializeField]
    private int m_ArenaBlockwidth = 100;

    public GameObject playerReference;

    [SerializeField]
    //khoảng thời gian giữa các lần tính toán mới vị trí của người chơi.
    private float TimeBetweenRecalculations=2;    
    private float m_TimeBetweenRecalculations;


    private int m_PlayreArenaBlockPosition;
    private int PlayerArenaBlockPosition
    {
        get { return m_PlayreArenaBlockPosition; }
        set 
        {  
            if(m_PlayreArenaBlockPosition != value)
            {
                m_PlayreArenaBlockPosition = value;
                UpdateArenaModel();
            }
            
        }
    }

    void Awake()
    {
        m_TimeBetweenRecalculations = TimeBetweenRecalculations;
        arenaBlocks = new List<ArenaBlock>(new ArenaBlock[9]);
        InitArena();
        playerReference = GameObject.FindGameObjectWithTag("Player");
        PlayerArenaBlockPosition = arenaBlocks[4].Position;

    }

    
    // Update is called once per frame
    void Update()
    {
        m_TimeBetweenRecalculations -= Time.deltaTime;
        if (m_TimeBetweenRecalculations > 0)
            return;
        m_TimeBetweenRecalculations = TimeBetweenRecalculations;

        if (playerReference != null)
        {
            playerReference = GameObject.FindGameObjectWithTag("Player");
        }
        PlayerArenaBlockPosition = GetArenaPositionClosestToPlayer();
        Debug.Log(PlayerArenaBlockPosition);
    }

    private void InitArena()
    {
        for(int i = 0;i<9;i++)
        {
            //Khởi tạo một GameObject/arenaBlock (đối tượng trong trò chơi)
            GameObject go = Instantiate(arenaBlockPrefab);

            //create arenaBlock
            ArenaBlock ab = new ArenaBlock()
            {
                Position = i,
                TheObject = go
            };
            //add it to the list of arenablock
            arenaBlocks[i] = ab;

            //then we want to place it in the world
            PlaceArenaBlock(ab, i);
        }
    }
    // hàm trả về vị trí của ArenaBlock gần người chơi nhất.
    private int GetArenaPositionClosestToPlayer()
    {
        float dist = Mathf.Infinity;
        int champ = -1;
        for(int i = 0; i < 9; i++)
        {
            //Calc dist
            ArenaBlock tmpBlock = arenaBlocks[i];
            float tmpDist = Vector3.Distance
                (
                    tmpBlock.TheObject.transform.position,
                    playerReference.transform.position
                );

            //Check & update dist, and champ
            if(tmpDist < dist)
            {
                dist = tmpDist;
                champ = tmpBlock.Position;
            }
        }

        return champ;
    }
    //hàm đặt ArenaBlock vào vị trí mới, theo hướng và số bước được chỉ định.
    private void PlaceArenaBlock(ArenaBlock ab, int pos, int steps = 1)
    {
        Vector3 dir = GetDirectionFromPos(pos) * steps;
        //(-1,0,1)
        Vector3 currentPos = ab.TheObject.transform.position;

        Vector3 newPos = currentPos + new Vector3
        (
            (m_ArenaBlockwidth) * dir.x,
            0,
            (m_ArenaBlockwidth) * dir.z
        );

        ab.TheObject.transform.position = newPos;

    }
    //hàm trả về hướng dẫn từ vị trí của ArenaBlock.
    private Vector3 GetDirectionFromPos(int pos)
    {
        switch(pos)
        {
            case 0:
                return new Vector3(-1, 0, 1);
            case 1:
                return new Vector3(0, 0, 1);
            case 2:
                return new Vector3(1, 0, 1);
            case 3:
                return new Vector3(-1, 0, 0);
            case 4:
                return new Vector3(0, 0, 0);
            case 5:
                return new Vector3(1, 0, 0);
            case 6:
                return new Vector3(-1, 0, -1);
            case 7:
                return new Vector3(0, 0, -1);
            case 8:
                return new Vector3(1, 0, -1);
            default:
                return new Vector3(0, 0, 0);
        }
    }
    //cập nhật vị trí của các ArenaBlock trong trường hợp người chơi di chuyển đến vị trí mới trên đấu trường.
    private void UpdateArenaModel()
    {
        switch (PlayerArenaBlockPosition)
        {
            case 0: //north west
                    //[0|1|2] move [8|5|2] update [0|1|2]
                    //[3|4|5]  ->  [7|0|1]   ->   [3|4|5]
                    //[6|7|8]      [6|3|4]        [6|7|8]
                PlaceArenaBlock(arenaBlocks[2], 0, 1);
                PlaceArenaBlock(arenaBlocks[6], 0, 1);
                PlaceArenaBlock(arenaBlocks[5], 0, 2);
                PlaceArenaBlock(arenaBlocks[7], 0, 2);
                PlaceArenaBlock(arenaBlocks[2], 0, 3);

                //update position
                arenaBlocks[8].Position = 0;
                arenaBlocks[5].Position = 1;
                arenaBlocks[2].Position = 2;
                arenaBlocks[7].Position = 3;
                arenaBlocks[0].Position = 4;
                arenaBlocks[1].Position = 5;
                arenaBlocks[6].Position = 6;
                arenaBlocks[3].Position = 7;
                arenaBlocks[4].Position = 8;
                break;

            case 1: //middle top
                    //[0|1|2] move [6|7|8] update [0|1|2]
                    //[3|4|5]  ->  [3|4|5]   ->   [7|8|0]
                    //[6|7|8]      [0|1|2]        [3|4|5]
                PlaceArenaBlock(arenaBlocks[8], 0, 1);
                PlaceArenaBlock(arenaBlocks[5], 1, 2);
                PlaceArenaBlock(arenaBlocks[0], 2, 2);
                PlaceArenaBlock(arenaBlocks[6], 2, 1);
                PlaceArenaBlock(arenaBlocks[7], 2, 0);

                //update position
                arenaBlocks[0].Position = 2;
                arenaBlocks[1].Position = 1;
                arenaBlocks[2].Position = 0;
                arenaBlocks[3].Position = 5;
                arenaBlocks[4].Position = 4;
                arenaBlocks[5].Position = 3;
                arenaBlocks[6].Position = 8;
                arenaBlocks[7].Position = 7;
                arenaBlocks[8].Position = 6;
                break;

            case 2: //north east
                    //update position
                PlaceArenaBlock(arenaBlocks[6], 0, 1);
                PlaceArenaBlock(arenaBlocks[7], 0, 2);
                PlaceArenaBlock(arenaBlocks[8], 0, 3);
                PlaceArenaBlock(arenaBlocks[5], 1, 2);
                PlaceArenaBlock(arenaBlocks[2], 2, 1);

                //update position
                arenaBlocks[0].Position = 0;
                arenaBlocks[1].Position = 1;
                arenaBlocks[2].Position = 2;
                arenaBlocks[3].Position = 3;
                arenaBlocks[4].Position = 4;
                arenaBlocks[5].Position = 5;
                arenaBlocks[6].Position = 0;
                arenaBlocks[8].Position = 6;
                arenaBlocks[7].Position = 7;
                arenaBlocks[4].Position = 8;
                break;
            case 3: //middle left
                    //[0|1|2] move [2|5|8] update [0|1|2]
                    //[3|4|5]  ->  [1|4|7]   ->   [3|0|6]
                    //[6|7|8]      [0|3|6]        [4|5|8]
                PlaceArenaBlock(arenaBlocks[8], 0, 1);
                PlaceArenaBlock(arenaBlocks[1], 1, 0);
                PlaceArenaBlock(arenaBlocks[4], 1, 1);
                PlaceArenaBlock(arenaBlocks[7], 1, 2);
                PlaceArenaBlock(arenaBlocks[2], 2, 2);

                //update position
                arenaBlocks[0].Position = 1;
                arenaBlocks[1].Position = 0;
                arenaBlocks[2].Position = 2;
                arenaBlocks[3].Position = 4;
                arenaBlocks[4].Position = 3;
                arenaBlocks[5].Position = 5;
                arenaBlocks[6].Position = 7;
                arenaBlocks[7].Position = 6;
                arenaBlocks[8].Position = 8;
                break;

            case 4: //middle
                    //[0|1|2] move [1|4|7] update [0|1|2]
                    //[3|4|5]  ->  [0|3|6]   ->   [3|4|5]
                    //[6|7|8]      [2|5|8]        [6|7|8]
                PlaceArenaBlock(arenaBlocks[7], 0, 1);
                PlaceArenaBlock(arenaBlocks[0], 1, 0);
                PlaceArenaBlock(arenaBlocks[3], 1, 1);
                PlaceArenaBlock(arenaBlocks[6], 1, 2);
                PlaceArenaBlock(arenaBlocks[1], 2, 2);

                //update position
                arenaBlocks[0].Position = 3;
                arenaBlocks[1].Position = 4;
                arenaBlocks[2].Position = 5;
                arenaBlocks[3].Position = 0;
                arenaBlocks[4].Position = 1;
                arenaBlocks[5].Position = 2;
                arenaBlocks[6].Position = 6;
                arenaBlocks[7].Position = 7;
                arenaBlocks[8].Position = 8;
                break;

            case 5: //middle right
                    //[0|1|2] move [0|3|6] update [0|1|2]
                    //[3|4|5]  ->  [1|4|7]   ->   [2|5|8]
                    //[6|7|8]      [2|5|8]        [1|4|7]
                PlaceArenaBlock(arenaBlocks[6], 0, 1);
                PlaceArenaBlock(arenaBlocks[1], 1, 2);
                PlaceArenaBlock(arenaBlocks[4], 1, 1);
                PlaceArenaBlock(arenaBlocks[7], 1, 0);
                PlaceArenaBlock(arenaBlocks[0], 2, 0);

                //update position
                arenaBlocks[0].Position = 6;
                arenaBlocks[1].Position = 2;
                arenaBlocks[2].Position = 8;
                arenaBlocks[3].Position = 3;
                arenaBlocks[4].Position = 4;
                arenaBlocks[5].Position = 5;
                arenaBlocks[6].Position = 0;
                arenaBlocks[7].Position = 1;
                arenaBlocks[8].Position = 2;
                break;
            case 6: //south west
                    //[0|1|2] move [6|3|0] update [6|7|8]
                    //[3|4|5]  ->  [7|4|1]   ->   [3|4|5]
                    //[6|7|8]      [8|5|2]        [0|1|2]
                PlaceArenaBlock(arenaBlocks[0], 0, 1);
                PlaceArenaBlock(arenaBlocks[3], 0, 1);
                PlaceArenaBlock(arenaBlocks[4], 0, 2);
                PlaceArenaBlock(arenaBlocks[7], 0, 2);
                PlaceArenaBlock(arenaBlocks[8], 0, 3);

                //update position
                arenaBlocks[0].Position = 6;
                arenaBlocks[1].Position = 7;
                arenaBlocks[2].Position = 8;
                arenaBlocks[3].Position = 3;
                arenaBlocks[4].Position = 4;
                arenaBlocks[5].Position = 5;
                arenaBlocks[6].Position = 0;
                arenaBlocks[7].Position = 1;
                arenaBlocks[8].Position = 2;
                break;

            case 7: //south
                    //[0|1|2] move [7|4|1] update [0|1|2]
                    //[3|4|5]  ->  [8|5|2]   ->   [3|4|5]
                    //[6|7|8]      [6|3|0]        [6|7|8]
                PlaceArenaBlock(arenaBlocks[1], 0, 1);
                PlaceArenaBlock(arenaBlocks[4], 0, 1);
                PlaceArenaBlock(arenaBlocks[5], 0, 2);
                PlaceArenaBlock(arenaBlocks[8], 0, 2);
                PlaceArenaBlock(arenaBlocks[7], 0, 3);

                //update position
                arenaBlocks[0].Position = 0;
                arenaBlocks[1].Position = 1;
                arenaBlocks[2].Position = 2;
                arenaBlocks[3].Position = 6;
                arenaBlocks[4].Position = 7;
                arenaBlocks[5].Position = 8;
                arenaBlocks[6].Position = 3;
                arenaBlocks[7].Position = 4;
                arenaBlocks[8].Position = 5;
                break;

            case 8: //south east
                    //[0|1|2] move [8|5|2] update [0|1|2]
                    //[3|4|5]  ->  [7|4|1]   ->   [6|7|8]
                    //[6|7|8]      [6|3|0]        [3|4|5]
                PlaceArenaBlock(arenaBlocks[2], 0, 1);
                PlaceArenaBlock(arenaBlocks[5], 0, 1);
                PlaceArenaBlock(arenaBlocks[4], 0, 2);
                PlaceArenaBlock(arenaBlocks[3], 0, 2);
                PlaceArenaBlock(arenaBlocks[6], 0, 3);
                //update position
                arenaBlocks[0].Position = 3;
                arenaBlocks[1].Position = 4;
                arenaBlocks[2].Position = 5;
                arenaBlocks[3].Position = 0;
                arenaBlocks[4].Position = 1;
                arenaBlocks[5].Position = 2;
                arenaBlocks[6].Position = 6;
                arenaBlocks[7].Position = 7;
                arenaBlocks[8].Position = 8;
                break;

            default:
                // do nothing if the block is in the center
                break;
        }
        //sort
        arenaBlocks.Sort((x, y) => x.Position.CompareTo(y.Position));
    }

    [SerializeField]
    public class ArenaBlock
    {
        public int Position;
        public GameObject TheObject;
    }
}

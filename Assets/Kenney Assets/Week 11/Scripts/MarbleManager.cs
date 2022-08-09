using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RachelleBray
{
    public class MarbleManager : MonoBehaviour
    {
        //spawn a marble every few seconds
        //Need to use "instantiate"

        [SerializeField] private GameObject marbleSpawnPoint;
        [SerializeField] private GameObject marblePrefab;
        [SerializeField] public List<GameObject> allMarbles = new List<GameObject>();


        [SerializeField] private float timer;
        [SerializeField] private float timerReset = 5;

        [SerializeField] private Vector3 averageMarblePosition;
        private void Start()
        {
            timer = timerReset;

        }

        // Update is called once per frame
        void Update()
        {
            timer -= Time.deltaTime;

            if (timer < 0)
            {
                timer = timerReset;

                //spawn  marble
                GameObject newMarble = Instantiate(marblePrefab, marbleSpawnPoint.transform.position, Quaternion.identity);

                //add force to make marble move quicker
                newMarble.GetComponent<Rigidbody>().AddForce(new Vector3(-50, -500, 0));
                allMarbles.Add(newMarble);
            }

            UpdateCameraLook();
        }

        private void UpdateCameraLook()
        {
            if (allMarbles.Count > 0)
            {
                for (int i = 0; i < allMarbles.Count; i++)
                {
                    averageMarblePosition += allMarbles[i].transform.position;
                }
                averageMarblePosition /= allMarbles.Count;

                Camera.main.transform.LookAt(averageMarblePosition);
            }
        }

       // void OnEnable()
       // {
        //    TriggerZone.OnTrigger += Destroy;

       // }

       // void OnDisable()
       // {
        //    TriggerZone.OnTrigger -= Destroy;

       // }

      //  void Destroy()
       // {
          //  Destroy(marblePrefab);

        //}
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{


    public class Carpisma : MonoBehaviour
    {
        public GameObject patlama;

        public GameObject PlayerDestroy;

        public GameObject uiw;

        private float t;

        private cubescript cubescript;

        public int scene;

        [SerializeField]
        private Transform player;

        [SerializeField]
        private Transform respawnPoint;
        public void ModeSelect()
        {
            base.StartCoroutine("Wait");
        }

        private void Start()
        {
            this.t = Time.time + 25f;
        }

        //Wait for few seconds for user to select respawn option
        private IEnumerator MyCourutine()
        {
            yield return null;
            Time.timeScale = 0f;
            yield return new WaitForSecondsRealtime(2.2f);
            this.Watchit();
            yield break;
        }

        private void OnCollisionEnter(Collision obj)
        {
            //Show Ads if it's ready and user played more than 25secs..
            UnityEngine.Debug.Log(Time.time);
            if (UnityEngine.Advertisements.Advertisement.IsReady() && Time.time > this.t)
            {

                this.t = Time.time + 25f;
                this.uiw.SetActive(!this.uiw.activeSelf);
                base.StartCoroutine(this.MyCourutine());
            }
            else
            {
                UnityEngine.Object.Instantiate<GameObject>(this.patlama, base.gameObject.transform.position, base.gameObject.transform.rotation);
                GameObject.Find("Sphere").SendMessage("Finish2");
                UnityEngine.Object.Destroy(this.PlayerDestroy);
                base.Invoke("WaitingFunction", 1f);
            }
        }

        private void WaitForSecondsRealtime(int v)
        {
            throw new NotImplementedException();
        }
        //
        public void Watchit()
        {
            UnityEngine.Advertisements.Advertisement.Show("rewardedVideo", new ShowOptions)
            {
                resultCallback = new Action<ShowResult>(this.HandleAdResult)
        });
        }
        //Do these based on watch time
        public void HandleAdResult(ShowResult result)
        {
            if (result != ShowResult.Finished)
            {
                if (result != ShowResult.Skipped)
                {
                    if (result == ShowResult.Failed)
                    {
                        UnityEngine.Object.Instantiate<GameObject>(this.patlama, base.gameObject.transform.position, base.gameObject.transform.rotation);
                        GameObject.Find("Sphere").SendMessage("Finish2");
                        UnityEngine.Object.Destroy(this.PlayerDestroy);
                        base.Invoke("WaitingFunction", 1f);
                    }
                }
                else
                {
                    UnityEngine.Object.Instantiate<GameObject>(this.patlama, base.gameObject.transform.position, base.gameObject.transform.rotation);
                    GameObject.Find("Sphere").SendMessage("Finish2");
                    UnityEngine.Object.Destroy(this.PlayerDestroy);
                    base.Invoke("WaitingFunction", 1f);
                }
            }
            else
            {
                Time.timeScale = 1f;
                UnityEngine.Object.Destroy(base.gameObject);
                this.uiw.SetActive(!this.uiw.activeSelf);
                UnityEngine.Debug.Log("bu itttt");
            }
        }

        private void WaitingFunction()
        {
            SceneManager.LoadScene(this.scene);
        }
        //Respawn button..
        public void again()
        {
            UnityEngine.Object.Instantiate<GameObject>(this.patlama, base.gameObject.transform.position, base.gameObject.transform.rotation);
            GameObject.Find("Sphere").SendMessage("Finish2");
            UnityEngine.Object.Destroy(this.PlayerDestroy);
            this.WaitingFunction();
        }


    } }

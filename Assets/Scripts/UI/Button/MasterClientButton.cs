using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MasterClientButton : MonoBehaviour
{
    private SoundButton button;

    private void OnEnable()
    {
        button = GetComponent<SoundButton>();
        StartCoroutine(Coroutine());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator Coroutine()
    {
        while (true)
        {
            if (RoomManager.Instance.playmode == RoomManager.Playmode.Single)
            {
                button.interactable = true;
            }
            else
            {
                button.interactable = PhotonNetwork.IsMasterClient;
            }

            yield return new WaitForSecondsRealtime(0.25f);
        }
    }
}

using UnityEngine;
using UnityEngine.Video;

public class VideoTriggerScript : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void Start()
    {
        // Get the VideoPlayer component attached to this GameObject.
        videoPlayer = GetComponent<VideoPlayer>();
    }

    // Call this method to start the video.
    public void PlayVideo()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Play();
            Debug.Log("Video started playing.");
        }
    }

    // Call this method to pause the video.
    public void PauseVideo()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Pause();
            Debug.Log("Video paused.");
        }
    }

    // Call this method to stop the video and rewind it.
    public void StopVideo()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Stop();
            Debug.Log("Video stopped.");
        }
    }
}
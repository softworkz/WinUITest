namespace PlayerProject
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;

    using Windows.Media.Playback;

    using FFmpegInteropX;

    public class PlayerTestClass
    {
        public MediaPlayer CreatePlayer()
        {
            return new MediaPlayer();
        }

        public async Task TestSetVideoToPlayer(MediaPlayer player)
        {
            try
            {
                var x = CharacterEncoding.GetSystemDefault();
                Debug.Print(x?.ToString());

                if (DateTime.Now.Ticks != 1)
                {
                    var mediaSource = await FFmpegMediaSource.CreateFromUriAsync("https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4");

                    var playbackItem = mediaSource.CreateMediaPlaybackItem();

                    player.Source = playbackItem;
                    
                    player.Play();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LikeChecker.Services
{
    public class VideoService
    {

        public string GetLikesCount(string videoUrl)
        {
            string videoId = GetVideoYouTubeId(videoUrl);
            string json = GetJson("https://www.googleapis.com/youtube/v3/videos?part=snippet&id=" + videoId + "&key=AIzaSyB7oqNYxEGnskHEpKHSCbIH_-VI4_sJkzg");
            var video = JsonConvert.DeserializeObject(json);
            return "";
        }
        private string GetVideoYouTubeId(string videoUrl)
        {
            string videoId = videoUrl;
            var regex = new Regex(@"watch\?v=([^&]+)(&)?");
            Match match = regex.Match(videoUrl);
            if (match.Success)
            {
                videoId = match.Groups[1].ToString();
            }
            return videoId;
        }
        private string GetJson(string url)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            return webClient.DownloadString(url);
        }
    }
}

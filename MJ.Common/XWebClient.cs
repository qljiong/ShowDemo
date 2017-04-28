using System;
using System.Net;
using System.Text;

namespace MJ.Common
{
    public static class XWebClient
    {
        /// <summary>
        /// 用WebClient Get方式请求Webservice服务
        /// </summary>
        /// <param name="url">带参数的Webservice服务地址</param>
        public static string Get(string url)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Encoding = Encoding.UTF8;
                    return webClient.DownloadString(url);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string Get(string url, string apikeyName, string apikeyValue)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add(apikeyName, apikeyValue);
                    webClient.Encoding = Encoding.UTF8;
                    return webClient.DownloadString(url);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string Post(string url, string arg)
        {
            byte[] postData = Encoding.UTF8.GetBytes(arg);
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                    byte[] responseData = webClient.UploadData(url, "POST", postData);
                    return Encoding.UTF8.GetString(responseData);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string Post(string url, string arg, string apikeyName, string apikeyValue)
        {
            byte[] postData = Encoding.UTF8.GetBytes(arg);
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                    webClient.Headers.Add(apikeyName, apikeyValue);
                    byte[] responseData = webClient.UploadData(url, "POST", postData);
                    return Encoding.UTF8.GetString(responseData);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

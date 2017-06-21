﻿using System;
using jmessage.message;
using System.Collections.Specialized;

namespace example.MessageExamples
{
    class UploadFileExample
    {
        public static string app_key = "6be9204c30b9473e87bad4dc";
        public static string master_secret = "a19bef7870c55d7e51f4c4f0";

        public static void Main(string[] args)
        {
            FileClient client = new FileClient(app_key, master_secret);
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("", "");
            string url = "https://api.im.jpush.cn/v1/resource?type=file";
            string filePath = @"C:\Users\fendouai\Desktop\NuGet.md";
            string content = client.HttpPostData(url, 600, "NuGet.md", filePath, nvc);
            Console.WriteLine(content);
            Console.ReadLine();
        }
    }
}



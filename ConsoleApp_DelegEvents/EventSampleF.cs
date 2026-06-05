using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DelegEvents
{
    public delegate void VideoEncodedEventHandler(string videoTitle);   // 1. Define a delegate
    public class VideoEncoder                                       // 2. Publisher class
    {
        public event VideoEncodedEventHandler VideoEncoded;     // 3. Declare the event

        public void Encode(string videoTitle)
        {
            Console.WriteLine($"Encoding video started: {videoTitle}...");
            System.Threading.Thread.Sleep(4000);                // Simulate encoding delay
            Console.WriteLine("Encoding completed.");
            OnVideoEncoded(videoTitle);             // 4. Raise the event
        }
        public virtual void OnVideoEncoded(string videoTitle)
        {
            if (VideoEncoded!=null)
                VideoEncoded(videoTitle);
            // else Console.WriteLine("No audio input provided for encoding");    //write this condition when events not registered. If no methods are subscribed, then delegate is null
        }
    }
    // 5. Subscriber classes
    public class MessageService : VideoEncoder           
    {
        public override void OnVideoEncoded(string videoTitle)
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"[MessageService] - SMS Sent upon encoding finished for video titled : '{videoTitle}'");
        }
    }
    public class MailService : VideoEncoder
    {
        public override void OnVideoEncoded(string videoTitle)
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"[MailService] - Mail sent upon encoding completion for video titled: '{videoTitle}'");
        }
    }

    class ProgramUI
    {
        //public static void Main()
        //{
        //    VideoEncoder videncoder = new VideoEncoder();               // Publisher

        //    MessageService msgService = new MessageService();           // Subscriber
        //    MailService mailservice = new MailService();                // Subscriber

        //    videncoder.VideoEncoded += msgService.OnVideoEncoded;     // 6. Subscribe to the event 
        //    //videncoder.VideoEncoded += mailservice.OnVideoEncoded;    // Or we can write this as :
        //    videncoder.VideoEncoded += new VideoEncodedEventHandler(mailservice.OnVideoEncoded);

        //    videncoder.Encode("Introduction_to_C#.mp4");             // 7. Trigger the event by calling Encode

        //    Console.ReadKey();
        //}
    }
}

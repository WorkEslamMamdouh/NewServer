using System;

namespace WindowsFormsApp1
{
    internal class RequestCacheControl
    {
        public RequestCacheControl()
        {
        }

        public bool NoCache { get; set; }
        public bool NoStore { get; set; }
        public TimeSpan MaxAge { get; set; }
    }
}
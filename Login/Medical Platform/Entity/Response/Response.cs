﻿namespace Medical_Platform.Entity.Response
{
    public class Response
    {
        public string Message { get; set; }

        public int HttpStatus { get; set; }

        public object Data { get; set; }
    }
}

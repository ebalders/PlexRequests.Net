﻿#region Copyright
// /************************************************************************
//    Copyright (c) 2016 Jamie Rees
//    File: PlexAuthentication.cs
//    Created By: Jamie Rees
//   
//    Permission is hereby granted, free of charge, to any person obtaining
//    a copy of this software and associated documentation files (the
//    "Software"), to deal in the Software without restriction, including
//    without limitation the rights to use, copy, modify, merge, publish,
//    distribute, sublicense, and/or sell copies of the Software, and to
//    permit persons to whom the Software is furnished to do so, subject to
//    the following conditions:
//   
//    The above copyright notice and this permission notice shall be
//    included in all copies or substantial portions of the Software.
//   
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//    MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
//    LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
//    OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
//    WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//  ************************************************************************/
#endregion

using System.Collections.Generic;

namespace PlexRequests.Api.Models.Plex
{
    public class PlexAuthentication
    {
        public User user { get; set; }
    }
    public class Subscription
    {
        public bool active { get; set; }
        public string status { get; set; }
        public object plan { get; set; }
        public object features { get; set; }
    }

    public class Roles
    {
        public List<object> roles { get; set; }
    }

    public class User
    {
        public string email { get; set; }
        public string uuid { get; set; }
        public string joined_at { get; set; }
        public string username { get; set; }
        public string title { get; set; }
        public string authentication_token { get; set; }
        public Subscription subscription { get; set; }
        public Roles roles { get; set; }
        public List<string> entitlements { get; set; }
        public object confirmed_at { get; set; }
        public int forum_id { get; set; }
    }
}


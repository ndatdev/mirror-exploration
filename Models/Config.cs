﻿/*
 * Copyright (c) 2013 Google Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except
 * in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software distributed under the
 * License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace MirrorQuickstart.Models
{
    /// <summary>
    /// Static class holding OAuth 2.0 configuration constants.
    /// </summary>
    internal static class Config
    {
        /// The OAuth2.0 Client ID of your project.
        /// </summary>
        public static readonly string CLIENT_ID = "655127568176.apps.googleusercontent.com";

        /// <summary>
        /// The OAuth2.0 Client secret of your project.
        /// </summary>
        public static readonly string CLIENT_SECRET = "YjeNleJWqnlMYoo8nZndebn8";

        /// <summary>
        /// The OAuth2.0 scopes required by your project.
        /// </summary>
        public static readonly string[] SCOPES = new String[]
        {
            "https://www.googleapis.com/auth/glass.timeline",
            "https://www.googleapis.com/auth/glass.location",
            "https://www.googleapis.com/auth/userinfo.profile"
        };

        /// <summary>
        /// The Redirect URI of your project.
        /// </summary>
        public static readonly string REDIRECT_URI = "http://localhost:61422/oauth2callback";
    }
}
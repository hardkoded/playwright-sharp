/*
 * MIT License
 *
 * Copyright (c) Microsoft Corporation.
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 *
 *
 * ------------------------------------------------------------------------------ 
 * <auto-generated> 
 * This code was generated by a tool at:
 * /utils/doclint/generateDotnetApi.js
 * 
 * Changes to this file may cause incorrect behavior and will be lost if 
 * the code is regenerated. 
 * </auto-generated> 
 * ------------------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Playwright
{
    /// <summary>
    /// <para>
    /// BrowserType provides methods to launch a specific browser instance or connect to
    /// an existing one. The following is a typical example of using Playwright to drive
    /// automation:
    /// </para>
    /// </summary>
    public partial interface IBrowserType
    {
        /// <summary><para>A path where Playwright expects to find a bundled browser executable.</para></summary>
        string ExecutablePath { get; }

        /// <summary>
        /// <para>Returns the browser instance.</para>
        /// <para>
        /// You can use <paramref name="ignoreDefaultArgs"/> to filter out <c>--mute-audio</c>
        /// from default arguments:
        /// </para>
        /// <para>
        /// > **Chromium-only** Playwright can also be used to control the Google Chrome or
        /// Microsoft Edge browsers, but it works best with the version of Chromium it is bundled
        /// with. There is no guarantee it will work with any other version. Use <paramref name="executablePath"/>
        /// option with extreme caution.
        /// </para>
        /// <para>></para>
        /// <para>
        /// > If Google Chrome (rather than Chromium) is preferred, a <a href="https://www.google.com/chrome/browser/canary.html">Chrome
        /// Canary</a> or <a href="https://www.chromium.org/getting-involved/dev-channel">Dev
        /// Channel</a> build is suggested.
        /// </para>
        /// <para>></para>
        /// <para>
        /// > Stock browsers like Google Chrome and Microsoft Edge are suitable for tests that
        /// require proprietary media codecs for video playback. See <a href="https://www.howtogeek.com/202825/what%E2%80%99s-the-difference-between-chromium-and-chrome/">this
        /// article</a> for other differences between Chromium and Chrome. <a href="https://chromium.googlesource.com/chromium/src/+/lkgr/docs/chromium_browser_vs_google_chrome.md">This
        /// article</a> describes some differences for Linux users.
        /// </para>
        /// </summary>
        /// <param name="headless">
        /// Whether to run browser in headless mode. More details for <a href="https://developers.google.com/web/updates/2017/04/headless-chrome">Chromium</a>
        /// and <a href="https://developer.mozilla.org/en-US/docs/Mozilla/Firefox/Headless_mode">Firefox</a>.
        /// Defaults to <c>true</c> unless the <paramref name="devtools"/> option is <c>true</c>.
        /// </param>
        /// <param name="channel">
        /// Browser distribution channel. Read more about using <a href="./browsers.md#google-chrome--microsoft-edge">Google
        /// Chrome and Microsoft Edge</a>.
        /// </param>
        /// <param name="executablePath">
        /// Path to a browser executable to run instead of the bundled one. If <paramref name="executablePath"/>
        /// is a relative path, then it is resolved relative to the current working directory.
        /// Note that Playwright only works with the bundled Chromium, Firefox or WebKit, use
        /// at your own risk.
        /// </param>
        /// <param name="args">
        /// Additional arguments to pass to the browser instance. The list of Chromium flags
        /// can be found <a href="http://peter.sh/experiments/chromium-command-line-switches/">here</a>.
        /// </param>
        /// <param name="proxy">Network proxy settings.</param>
        /// <param name="downloadsPath">
        /// If specified, accepted downloads are downloaded into this directory. Otherwise,
        /// temporary directory is created and is deleted when browser is closed.
        /// </param>
        /// <param name="chromiumSandbox">Enable Chromium sandboxing. Defaults to <c>false</c>.</param>
        /// <param name="firefoxUserPrefs">Firefox user preferences. Learn more about the Firefox user preferences at <a href="https://support.mozilla.org/en-US/kb/about-config-editor-firefox"><c>about:config</c></a>.</param>
        /// <param name="handleSIGINT">Close the browser process on Ctrl-C. Defaults to <c>true</c>.</param>
        /// <param name="handleSIGTERM">Close the browser process on SIGTERM. Defaults to <c>true</c>.</param>
        /// <param name="handleSIGHUP">Close the browser process on SIGHUP. Defaults to <c>true</c>.</param>
        /// <param name="timeout">
        /// Maximum time in milliseconds to wait for the browser instance to start. Defaults
        /// to <c>30000</c> (30 seconds). Pass <c>0</c> to disable timeout.
        /// </param>
        /// <param name="env">Specify environment variables that will be visible to the browser. Defaults to <c>process.env</c>.</param>
        /// <param name="devtools">
        /// **Chromium-only** Whether to auto-open a Developer Tools panel for each tab. If
        /// this option is <c>true</c>, the <paramref name="headless"/> option will be set <c>false</c>.
        /// </param>
        /// <param name="slowMo">
        /// Slows down Playwright operations by the specified amount of milliseconds. Useful
        /// so that you can see what is going on.
        /// </param>
        /// <param name="ignoreDefaultArgs">
        /// If <c>true</c>, Playwright does not pass its own configurations args and only uses
        /// the ones from <paramref name="args"/>. Dangerous option; use with care.
        /// </param>
        /// <param name="ignoreAllDefaultArgs">
        /// If <c>true</c>, Playwright does not pass its own configurations args and only uses
        /// the ones from <paramref name="args"/>. Dangerous option; use with care. Defaults
        /// to <c>false</c>.
        /// </param>
        Task<IBrowser> LaunchAsync(bool? headless = default, BrowserChannel channel = default, string executablePath = default, IEnumerable<string> args = default, Proxy proxy = default, string downloadsPath = default, bool? chromiumSandbox = default, IEnumerable<KeyValuePair<string, object>> firefoxUserPrefs = default, bool? handleSIGINT = default, bool? handleSIGTERM = default, bool? handleSIGHUP = default, float? timeout = default, IEnumerable<KeyValuePair<string, string>> env = default, bool? devtools = default, float? slowMo = default, IEnumerable<string> ignoreDefaultArgs = default, bool? ignoreAllDefaultArgs = default);

        /// <summary>
        /// <para>Returns the persistent browser context instance.</para>
        /// <para>
        /// Launches browser that uses persistent storage located at <paramref name="userDataDir"/>
        /// and returns the only context. Closing this context will automatically close the
        /// browser.
        /// </para>
        /// </summary>
        /// <param name="userDataDir">
        /// Path to a User Data Directory, which stores browser session data like cookies and
        /// local storage. More details for <a href="https://chromium.googlesource.com/chromium/src/+/master/docs/user_data_dir.md#introduction">Chromium</a>
        /// and <a href="https://developer.mozilla.org/en-US/docs/Mozilla/Command_Line_Options#User_Profile">Firefox</a>.
        /// Note that Chromium's user data directory is the **parent** directory of the "Profile
        /// Path" seen at <c>chrome://version</c>.
        /// </param>
        /// <param name="headless">
        /// Whether to run browser in headless mode. More details for <a href="https://developers.google.com/web/updates/2017/04/headless-chrome">Chromium</a>
        /// and <a href="https://developer.mozilla.org/en-US/docs/Mozilla/Firefox/Headless_mode">Firefox</a>.
        /// Defaults to <c>true</c> unless the <paramref name="devtools"/> option is <c>true</c>.
        /// </param>
        /// <param name="channel">Browser distribution channel.</param>
        /// <param name="executablePath">
        /// Path to a browser executable to run instead of the bundled one. If <paramref name="executablePath"/>
        /// is a relative path, then it is resolved relative to the current working directory.
        /// **BEWARE**: Playwright is only guaranteed to work with the bundled Chromium, Firefox
        /// or WebKit, use at your own risk.
        /// </param>
        /// <param name="args">
        /// Additional arguments to pass to the browser instance. The list of Chromium flags
        /// can be found <a href="http://peter.sh/experiments/chromium-command-line-switches/">here</a>.
        /// </param>
        /// <param name="proxy">Network proxy settings.</param>
        /// <param name="downloadsPath">
        /// If specified, accepted downloads are downloaded into this directory. Otherwise,
        /// temporary directory is created and is deleted when browser is closed.
        /// </param>
        /// <param name="chromiumSandbox">Enable Chromium sandboxing. Defaults to <c>true</c>.</param>
        /// <param name="handleSIGINT">Close the browser process on Ctrl-C. Defaults to <c>true</c>.</param>
        /// <param name="handleSIGTERM">Close the browser process on SIGTERM. Defaults to <c>true</c>.</param>
        /// <param name="handleSIGHUP">Close the browser process on SIGHUP. Defaults to <c>true</c>.</param>
        /// <param name="timeout">
        /// Maximum time in milliseconds to wait for the browser instance to start. Defaults
        /// to <c>30000</c> (30 seconds). Pass <c>0</c> to disable timeout.
        /// </param>
        /// <param name="env">Specify environment variables that will be visible to the browser. Defaults to <c>process.env</c>.</param>
        /// <param name="devtools">
        /// **Chromium-only** Whether to auto-open a Developer Tools panel for each tab. If
        /// this option is <c>true</c>, the <paramref name="headless"/> option will be set <c>false</c>.
        /// </param>
        /// <param name="slowMo">
        /// Slows down Playwright operations by the specified amount of milliseconds. Useful
        /// so that you can see what is going on. Defaults to 0.
        /// </param>
        /// <param name="acceptDownloads">
        /// Whether to automatically download all the attachments. Defaults to <c>false</c>
        /// where all the downloads are canceled.
        /// </param>
        /// <param name="ignoreHTTPSErrors">Whether to ignore HTTPS errors during navigation. Defaults to <c>false</c>.</param>
        /// <param name="bypassCSP">Toggles bypassing page's Content-Security-Policy.</param>
        /// <param name="viewportSize">
        /// Emulates consistent viewport for each page. Defaults to an 1280x720 viewport. Use
        /// <c>ViewportSize.NoViewport</c> to disable the default viewport.
        /// </param>
        /// <param name="screenSize">
        /// Emulates consistent window screen size available inside web page via <c>window.screen</c>.
        /// Is only used when the <paramref name="viewportSize"/> is set.
        /// </param>
        /// <param name="userAgent">Specific user agent to use in this context.</param>
        /// <param name="deviceScaleFactor">Specify device scale factor (can be thought of as dpr). Defaults to <c>1</c>.</param>
        /// <param name="isMobile">
        /// Whether the <c>meta viewport</c> tag is taken into account and touch events are
        /// enabled. Defaults to <c>false</c>. Not supported in Firefox.
        /// </param>
        /// <param name="hasTouch">Specifies if viewport supports touch events. Defaults to false.</param>
        /// <param name="javaScriptEnabled">Whether or not to enable JavaScript in the context. Defaults to <c>true</c>.</param>
        /// <param name="timezoneId">
        /// Changes the timezone of the context. See <a href="https://cs.chromium.org/chromium/src/third_party/icu/source/data/misc/metaZones.txt?rcl=faee8bc70570192d82d2978a71e2a615788597d1">ICU's
        /// metaZones.txt</a> for a list of supported timezone IDs.
        /// </param>
        /// <param name="geolocation">
        /// </param>
        /// <param name="locale">
        /// Specify user locale, for example <c>en-GB</c>, <c>de-DE</c>, etc. Locale will affect
        /// <c>navigator.language</c> value, <c>Accept-Language</c> request header value as
        /// well as number and date formatting rules.
        /// </param>
        /// <param name="permissions">
        /// A list of permissions to grant to all pages in this context. See <see cref="IBrowserContext.GrantPermissionsAsync"/>
        /// for more details.
        /// </param>
        /// <param name="extraHTTPHeaders">
        /// An object containing additional HTTP headers to be sent with every request. All
        /// header values must be strings.
        /// </param>
        /// <param name="offline">Whether to emulate network being offline. Defaults to <c>false</c>.</param>
        /// <param name="httpCredentials">
        /// Credentials for <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Authentication">HTTP
        /// authentication</a>.
        /// </param>
        /// <param name="colorScheme">
        /// Emulates <c>'prefers-colors-scheme'</c> media feature, supported values are <c>'light'</c>,
        /// <c>'dark'</c>, <c>'no-preference'</c>. See <see cref="IPage.EmulateMediaAsync"/>
        /// for more details. Defaults to <c>'light'</c>.
        /// </param>
        /// <param name="recordHarPath">
        /// Enables <a href="http://www.softwareishard.com/blog/har-12-spec">HAR</a> recording
        /// for all pages into the specified HAR file on the filesystem. If not specified, the
        /// HAR is not recorded. Make sure to call <see cref="IBrowserContext.CloseAsync"/>
        /// for the HAR to be saved.
        /// </param>
        /// <param name="recordHarOmitContent">
        /// Optional setting to control whether to omit request content from the HAR. Defaults
        /// to <c>false</c>.
        /// </param>
        /// <param name="recordVideoDir">
        /// Enables video recording for all pages into the specified directory. If not specified
        /// videos are not recorded. Make sure to call <see cref="IBrowserContext.CloseAsync"/>
        /// for videos to be saved.
        /// </param>
        /// <param name="recordVideoSize">
        /// Dimensions of the recorded videos. If not specified the size will be equal to <c>viewport</c>
        /// scaled down to fit into 800x800. If <c>viewport</c> is not configured explicitly
        /// the video size defaults to 800x450. Actual picture of each page will be scaled down
        /// if necessary to fit the specified size.
        /// </param>
        /// <param name="ignoreDefaultArgs">
        /// If <c>true</c>, Playwright does not pass its own configurations args and only uses
        /// the ones from <paramref name="args"/>. Dangerous option; use with care.
        /// </param>
        /// <param name="ignoreAllDefaultArgs">
        /// If <c>true</c>, Playwright does not pass its own configurations args and only uses
        /// the ones from <paramref name="args"/>. Dangerous option; use with care. Defaults
        /// to <c>false</c>.
        /// </param>
        Task<IBrowserContext> LaunchPersistentContextAsync(string userDataDir, bool? headless = default, BrowserChannel channel = default, string executablePath = default, IEnumerable<string> args = default, Proxy proxy = default, string downloadsPath = default, bool? chromiumSandbox = default, bool? handleSIGINT = default, bool? handleSIGTERM = default, bool? handleSIGHUP = default, float? timeout = default, IEnumerable<KeyValuePair<string, string>> env = default, bool? devtools = default, float? slowMo = default, bool? acceptDownloads = default, bool? ignoreHTTPSErrors = default, bool? bypassCSP = default, ViewportSize viewportSize = default, ScreenSize screenSize = default, string userAgent = default, float? deviceScaleFactor = default, bool? isMobile = default, bool? hasTouch = default, bool? javaScriptEnabled = default, string timezoneId = default, Geolocation geolocation = default, string locale = default, IEnumerable<string> permissions = default, IEnumerable<KeyValuePair<string, string>> extraHTTPHeaders = default, bool? offline = default, HttpCredentials httpCredentials = default, ColorScheme colorScheme = default, string recordHarPath = default, bool? recordHarOmitContent = default, string recordVideoDir = default, RecordVideoSize recordVideoSize = default, IEnumerable<string> ignoreDefaultArgs = default, bool? ignoreAllDefaultArgs = default);

        /// <summary><para>Returns browser name. For example: <c>'chromium'</c>, <c>'webkit'</c> or <c>'firefox'</c>.</para></summary>
        string Name { get; }
    }
}

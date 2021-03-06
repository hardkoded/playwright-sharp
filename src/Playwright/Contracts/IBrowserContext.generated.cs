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
	/// <para>BrowserContexts provide a way to operate multiple independent browser sessions.</para>
	/// <para>
	/// If a page opens another page, e.g. with a <c>window.open</c> call, the popup will
	/// belong to the parent page's browser context.
	/// </para>
	/// <para>
	/// Playwright allows creation of "incognito" browser contexts with <c>browser.newContext()</c>
	/// method. "Incognito" browser contexts don't write any browsing data to disk.
	/// </para>
	/// </summary>
	public partial interface IBrowserContext
	{
		/// <summary>
		/// <para>
		/// Emitted when Browser context gets closed. This might happen because of one of the
		/// following:
		/// </para>
		/// <list type="bullet">
		/// <item><description>Browser context is closed.</description></item>
		/// <item><description>Browser application is closed or crashed.</description></item>
		/// <item><description>The <see cref="IBrowser.CloseAsync"/> method was called.</description></item>
		/// </list>
		/// </summary>
		event EventHandler<IBrowserContext> Close;
	
		/// <summary>
		/// <para>
		/// The event is emitted when a new Page is created in the BrowserContext. The page
		/// may still be loading. The event will also fire for popup pages. See also <see cref="IPage.Popup"/>
		/// to receive events about popups relevant to a specific page.
		/// </para>
		/// <para>
		/// The earliest moment that page is available is when it has navigated to the initial
		/// url. For example, when opening a popup with <c>window.open('http://example.com')</c>,
		/// this event will fire when the network request to "http://example.com" is done and
		/// its response has started loading in the popup.
		/// </para>
		/// </summary>
		/// <remarks>
		/// <para>
		/// Use <see cref="IPage.WaitForLoadStateAsync"/> to wait until the page gets to a particular
		/// state (you should not need it in most cases).
		/// </para>
		/// </remarks>
		event EventHandler<IPage> Page;
	
		/// <summary>
		/// <para>
		/// Adds cookies into this browser context. All pages within this context will have
		/// these cookies installed. Cookies can be obtained via <see cref="IBrowserContext.GetCookiesAsync"/>.
		/// </para>
		/// </summary>
		/// <param name="cookies">
		/// </param>
		Task AddCookiesAsync(IEnumerable<Cookie> cookies);

        /// <summary>
        /// <para>Adds a script which would be evaluated in one of the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>Whenever a page is created in the browser context or is navigated.</description></item>
        /// <item><description>
        /// Whenever a child frame is attached or navigated in any page in the browser context.
        /// In this case, the script is evaluated in the context of the newly attached frame.
        /// </description></item>
        /// </list>
        /// <para>
        /// The script is evaluated after the document was created but before any of its scripts
        /// were run. This is useful to amend the JavaScript environment, e.g. to seed <c>Math.random</c>.
        /// </para>
        /// <para>An example of overriding <c>Math.random</c> before the page loads:</para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// The order of evaluation of multiple scripts installed via <see cref="IBrowserContext.AddInitScriptAsync"/>
        /// and <see cref="IPage.AddInitScriptAsync"/> is not defined.
        /// </para>
        /// </remarks>
        /// <param name="script">Script to be evaluated in all pages in the browser context.</param>
        /// <param name="scriptPath">Instead of specifying <paramref name="script"/>, gives the file name to load from.</param>
        /// <param name="arg">
		/// Optional argument to pass to <paramref name="script"/> (only supported when passing
		/// a function).
		/// </param>
        Task AddInitScriptAsync(string script = null, string scriptPath = null, object arg = default);

        /// <summary>
        /// <para>
        /// Returns the browser instance of the context. If it was launched as a persistent
        /// context null gets returned.
        /// </para>
        /// </summary>
        IBrowser Browser { get; }
	
		/// <summary><para>Clears context cookies.</para></summary>
		Task ClearCookiesAsync();
	
		/// <summary><para>Clears all permission overrides for the browser context.</para></summary>
		Task ClearPermissionsAsync();
	
		/// <summary>
		/// <para>
		/// Closes the browser context. All the pages that belong to the browser context will
		/// be closed.
		/// </para>
		/// </summary>
		/// <remarks><para>The default browser context cannot be closed.</para></remarks>
		Task CloseAsync();
	
		/// <summary>
		/// <para>
		/// If no URLs are specified, this method returns all cookies. If URLs are specified,
		/// only cookies that affect those URLs are returned.
		/// </para>
		/// </summary>
		/// <param name="urls">Optional list of URLs.</param>
		Task<IReadOnlyCollection<BrowserContextCookiesResult>> GetCookiesAsync(IEnumerable<string> urls = default);
	
		/// <summary>
		/// <para>
		/// The method adds a function called <paramref name="name"/> on the <c>window</c> object
		/// of every frame in every page in the context. When called, the function executes
		/// <paramref name="callback"/> and returns a <see cref="Promise"/> which resolves to
		/// the return value of <paramref name="callback"/>. If the <paramref name="callback"/>
		/// returns a <see cref="Promise"/>, it will be awaited.
		/// </para>
		/// <para>
		/// The first argument of the <paramref name="callback"/> function contains information
		/// about the caller: <c>{ browserContext: BrowserContext, page: Page, frame: Frame
		/// }</c>.
		/// </para>
		/// <para>See <see cref="IPage.ExposeBindingAsync"/> for page-only version.</para>
		/// <para>An example of exposing page URL to all frames in all pages in the context:</para>
		/// <para>An example of passing an element handle:</para>
		/// </summary>
		/// <param name="name">Name of the function on the window object.</param>
		/// <param name="callback">Callback function that will be called in the Playwright's context.</param>
		/// <param name="handle">
		/// Whether to pass the argument as a handle, instead of passing by value. When passing
		/// a handle, only one argument is supported. When passing by value, multiple arguments
		/// are supported.
		/// </param>
		Task ExposeBindingAsync(string name, Action callback, bool? handle = default);
	
		/// <summary>
		/// <para>
		/// The method adds a function called <paramref name="name"/> on the <c>window</c> object
		/// of every frame in every page in the context. When called, the function executes
		/// <paramref name="callback"/> and returns a <see cref="Promise"/> which resolves to
		/// the return value of <paramref name="callback"/>.
		/// </para>
		/// <para>If the <paramref name="callback"/> returns a <see cref="Promise"/>, it will be awaited.</para>
		/// <para>See <see cref="IPage.ExposeFunctionAsync"/> for page-only version.</para>
		/// <para>An example of adding an <c>md5</c> function to all pages in the context:</para>
		/// </summary>
		/// <param name="name">Name of the function on the window object.</param>
		/// <param name="callback">Callback function that will be called in the Playwright's context.</param>
		Task ExposeFunctionAsync(string name, Action callback);
	
		/// <summary>
		/// <para>
		/// Grants specified permissions to the browser context. Only grants corresponding permissions
		/// to the given origin if specified.
		/// </para>
		/// </summary>
		/// <param name="permissions">
		/// A permission or an array of permissions to grant. Permissions can be one of the
		/// following values:
		/// <list type="bullet">
		/// <item><description><c>'geolocation'</c></description></item>
		/// <item><description><c>'midi'</c></description></item>
		/// <item><description><c>'midi-sysex'</c> (system-exclusive midi)</description></item>
		/// <item><description><c>'notifications'</c></description></item>
		/// <item><description><c>'push'</c></description></item>
		/// <item><description><c>'camera'</c></description></item>
		/// <item><description><c>'microphone'</c></description></item>
		/// <item><description><c>'background-sync'</c></description></item>
		/// <item><description><c>'ambient-light-sensor'</c></description></item>
		/// <item><description><c>'accelerometer'</c></description></item>
		/// <item><description><c>'gyroscope'</c></description></item>
		/// <item><description><c>'magnetometer'</c></description></item>
		/// <item><description><c>'accessibility-events'</c></description></item>
		/// <item><description><c>'clipboard-read'</c></description></item>
		/// <item><description><c>'clipboard-write'</c></description></item>
		/// <item><description><c>'payment-handler'</c></description></item>
		/// </list>
		/// </param>
		/// <param name="origin">The <see cref="origin"/> to grant permissions to, e.g. "https://example.com".</param>
		Task GrantPermissionsAsync(IEnumerable<string> permissions, string origin = default);
	
		/// <summary><para>Creates a new page in the browser context.</para></summary>
		Task<IPage> NewPageAsync();
	
		/// <summary><para>Returns all open pages in the context.</para></summary>
		IReadOnlyCollection<IPage> Pages { get; }
	
		/// <summary>
		/// <para>
		/// Routing provides the capability to modify network requests that are made by any
		/// page in the browser context. Once route is enabled, every request matching the url
		/// pattern will stall unless it's continued, fulfilled or aborted.
		/// </para>
		/// <para>An example of a naive handler that aborts all image requests:</para>
		/// <para>or the same snippet using a regex pattern instead:</para>
		/// <para>
		/// Page routes (set up with <see cref="IPage.RouteAsync"/>) take precedence over browser
		/// context routes when request matches both handlers.
		/// </para>
		/// <para>To remove a route with its handler you can use <see cref="IBrowserContext.UnrouteAsync"/>.</para>
		/// </summary>
		/// <remarks><para>Enabling routing disables http cache.</para></remarks>
		/// <param name="urlString">
		/// A glob pattern, regex pattern or predicate receiving <see cref="URL"/> to match
		/// while routing.
		/// </param>
		/// <param name="urlRegex">
		/// A glob pattern, regex pattern or predicate receiving <see cref="URL"/> to match
		/// while routing.
		/// </param>
		/// <param name="urlFunc">
		/// A glob pattern, regex pattern or predicate receiving <see cref="URL"/> to match
		/// while routing.
		/// </param>
		/// <param name="handler">handler function to route the request.</param>
		Task RouteAsync(string urlString, Regex urlRegex, Func<string, bool> urlFunc, Action<IRoute> handler);
	
		/// <summary>
		/// <para>
		/// This setting will change the default maximum navigation time for the following methods
		/// and related shortcuts:
		/// </para>
		/// <list type="bullet">
		/// <item><description><see cref="IPage.GoBackAsync"/></description></item>
		/// <item><description><see cref="IPage.GoForwardAsync"/></description></item>
		/// <item><description><see cref="IPage.GoToAsync"/></description></item>
		/// <item><description><see cref="IPage.ReloadAsync"/></description></item>
		/// <item><description><see cref="IPage.SetContentAsync"/></description></item>
		/// <item><description><see cref="IPage.WaitForNavigationAsync"/></description></item>
		/// </list>
		/// </summary>
		/// <remarks>
		/// <para>
		/// <see cref="IPage.SetDefaultNavigationTimeout"/> and <see cref="IPage.SetDefaultTimeout"/>
		/// take priority over <see cref="IBrowserContext.SetDefaultNavigationTimeout"/>.
		/// </para>
		/// </remarks>
		float DefaultNavigationTimeout { get; set; }
	
		/// <summary>
		/// <para>
		/// This setting will change the default maximum time for all the methods accepting
		/// `timeout` option.
		/// </para>
		/// </summary>
		/// <remarks>
		/// <para>
		/// <see cref="IPage.SetDefaultNavigationTimeout"/>, <see cref="IPage.SetDefaultTimeout"/>
		/// and <see cref="IBrowserContext.SetDefaultNavigationTimeout"/> take priority over
		/// <see cref="IBrowserContext.SetDefaultTimeout"/>.
		/// </para>
		/// </remarks>
		float DefaultTimeout { get; set; }
	
		/// <summary>
		/// <para>
		/// The extra HTTP headers will be sent with every request initiated by any page in
		/// the context. These headers are merged with page-specific extra HTTP headers set
		/// with <see cref="IPage.SetExtraHttpHeadersAsync"/>. If page overrides a particular
		/// header, page-specific header value will be used instead of the browser context header
		/// value.
		/// </para>
		/// </summary>
		/// <remarks>
		/// <para>
		/// <see cref="IBrowserContext.SetExtraHttpHeadersAsync"/> does not guarantee the order
		/// of headers in the outgoing requests.
		/// </para>
		/// </remarks>
		/// <param name="headers">
		/// An object containing additional HTTP headers to be sent with every request. All
		/// header values must be strings.
		/// </param>
		Task SetExtraHttpHeadersAsync(IEnumerable<KeyValuePair<string, string>> headers);
	
		/// <summary>
		/// <para>
		/// Sets the context's geolocation. Passing <c>null</c> or <c>undefined</c> emulates
		/// position unavailable.
		/// </para>
		/// </summary>
		/// <remarks>
		/// <para>
		/// Consider using <see cref="IBrowserContext.GrantPermissionsAsync"/> to grant permissions
		/// for the browser context pages to read its geolocation.
		/// </para>
		/// </remarks>
		/// <param name="geolocation">
		/// </param>
		Task SetGeolocationAsync(Geolocation geolocation);
	
		/// <param name="offline">Whether to emulate network being offline for the browser context.</param>
		Task SetOfflineAsync(bool offline);
	
		/// <summary>
		/// <para>
		/// Returns storage state for this browser context, contains current cookies and local
		/// storage snapshot.
		/// </para>
		/// </summary>
		/// <param name="path">
		/// The file path to save the storage state to. If <paramref name="path"/> is a relative
		/// path, then it is resolved relative to current working directory. If no path is provided,
		/// storage state is still returned, but won't be saved to the disk.
		/// </param>
		Task<string> StorageStateAsync(string path = default);
	
		/// <summary>
		/// <para>
		/// Removes a route created with <see cref="IBrowserContext.RouteAsync"/>. When <paramref
		/// name="handler"/> is not specified, removes all routes for the <paramref name="urlString"/>.
		/// </para>
		/// </summary>
		/// <param name="urlString">
		/// A glob pattern, regex pattern or predicate receiving <see cref="URL"/> used to register
		/// a routing with <see cref="IBrowserContext.RouteAsync"/>.
		/// </param>
		/// <param name="urlRegex">
		/// A glob pattern, regex pattern or predicate receiving <see cref="URL"/> used to register
		/// a routing with <see cref="IBrowserContext.RouteAsync"/>.
		/// </param>
		/// <param name="urlFunc">
		/// A glob pattern, regex pattern or predicate receiving <see cref="URL"/> used to register
		/// a routing with <see cref="IBrowserContext.RouteAsync"/>.
		/// </param>
		/// <param name="handler">Optional handler function used to register a routing with <see cref="IBrowserContext.RouteAsync"/>.</param>
		Task UnrouteAsync(string urlString, Regex urlRegex, Func<string, bool> urlFunc, Action<IRoute> handler = default);
	
		/// <summary>
		/// <para>
		/// Waits for event to fire and passes its value into the predicate function. Returns
		/// when the predicate returns truthy value. Will throw an error if the context closes
		/// before the event is fired. Returns the event data value.
		/// </para>
		/// </summary>
		/// <param name="event">Event name, same one would pass into <c>browserContext.on(event)</c>.</param>
		/// <param name="timeout">
		/// Maximum time to wait for in milliseconds. Defaults to <c>30000</c> (30 seconds).
		/// Pass <c>0</c> to disable timeout. The default value can be changed by using the
		/// <see cref="IBrowserContext.SetDefaultTimeout"/>.
		/// </param>
		Task<object> WaitForEventAsync(string @event, float? timeout = default);
	
		/// <summary>
		/// <para>
		/// Performs action and waits for a new <see cref="IPage"/> to be created in the context.
		/// If predicate is provided, it passes <see cref="IPage"/> value into the <c>predicate</c>
		/// function and waits for <c>predicate(event)</c> to return a truthy value. Will throw
		/// an error if the context closes before new <see cref="IPage"/> is created.
		/// </para>
		/// </summary>
		/// <param name="predicate">
		/// Receives the <see cref="IPage"/> object and resolves to truthy value when the waiting
		/// should resolve.
		/// </param>
		/// <param name="timeout">
		/// Maximum time to wait for in milliseconds. Defaults to <c>30000</c> (30 seconds).
		/// Pass <c>0</c> to disable timeout. The default value can be changed by using the
		/// <see cref="IBrowserContext.SetDefaultTimeout"/>.
		/// </param>
		Task<IPage> WaitForPageAsync(Func<IPage, bool> predicate = default, float? timeout = default);
	}
}

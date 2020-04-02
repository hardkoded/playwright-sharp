//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;
using System.Text.Json.Serialization;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace PlaywrightSharp.Firefox.Protocol.Browser
{
internal partial class CookieOptions
{
public string Name { get; set; }
public string Value { get; set; }
public string Url { get; set; }
public string Domain { get; set; }
public string Path { get; set; }
public bool? Secure { get; set; }
public bool? HttpOnly { get; set; }
public Browser.CookieOptionsSameSite? SameSite { get; set; }
public double? Expires { get; set; }
}
internal partial class Cookie
{
public string Name { get; set; }
public string Domain { get; set; }
public string Path { get; set; }
public string Value { get; set; }
public double? Expires { get; set; }
public double? Size { get; set; }
public bool? HttpOnly { get; set; }
public bool? Secure { get; set; }
public bool? Session { get; set; }
public Browser.CookieOptionsSameSite SameSite { get; set; }
}
[JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
internal enum CookieOptionsSameSite
{
[System.Runtime.Serialization.EnumMember(Value = "Strict")]Strict,
[System.Runtime.Serialization.EnumMember(Value = "Lax")]Lax,
[System.Runtime.Serialization.EnumMember(Value = "None")]None,
}
}
namespace PlaywrightSharp.Firefox.Protocol.Target
{
internal partial class TargetInfo
{
public Target.TargetInfoType Type { get; set; }
public string TargetId { get; set; }
public string BrowserContextId { get; set; }
public string Url { get; set; }
public string OpenerId { get; set; }
}
[JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
internal enum TargetInfoType
{
[System.Runtime.Serialization.EnumMember(Value = "page")]Page,
[System.Runtime.Serialization.EnumMember(Value = "browser")]Browser,
}
}
namespace PlaywrightSharp.Firefox.Protocol.Page
{
internal partial class DOMPoint
{
public double? X { get; set; }
public double? Y { get; set; }
}
internal partial class BoundingBox
{
public double? X { get; set; }
public double? Y { get; set; }
public double? Width { get; set; }
public double? Height { get; set; }
}
internal partial class Viewport
{
public double? Width { get; set; }
public double? Height { get; set; }
public double? DeviceScaleFactor { get; set; }
public bool? IsMobile { get; set; }
public bool? HasTouch { get; set; }
public bool? IsLandscape { get; set; }
}
internal partial class DOMQuad
{
public Page.DOMPoint P1 { get; set; }
public Page.DOMPoint P2 { get; set; }
public Page.DOMPoint P3 { get; set; }
public Page.DOMPoint P4 { get; set; }
}
internal partial class TouchPoint
{
public double? X { get; set; }
public double? Y { get; set; }
public double? RadiusX { get; set; }
public double? RadiusY { get; set; }
public double? RotationAngle { get; set; }
public double? Force { get; set; }
}
internal partial class Clip
{
public double? X { get; set; }
public double? Y { get; set; }
public double? Width { get; set; }
public double? Height { get; set; }
}
}
namespace PlaywrightSharp.Firefox.Protocol.Runtime
{
internal partial class RemoteObject
{
public Runtime.RemoteObjectType? Type { get; set; }
public Runtime.RemoteObjectSubtype? Subtype { get; set; }
public string ObjectId { get; set; }
public Runtime.RemoteObjectUnserializableValue? UnserializableValue { get; set; }
public object Value { get; set; }
}
internal partial class ObjectProperty
{
public string Name { get; set; }
public Runtime.RemoteObject Value { get; set; }
}
internal partial class ScriptLocation
{
public double? ColumnNumber { get; set; }
public double? LineNumber { get; set; }
public string Url { get; set; }
}
internal partial class ExceptionDetails
{
public string Text { get; set; }
public string Stack { get; set; }
public object Value { get; set; }
}
internal partial class CallFunctionArgument
{
public string ObjectId { get; set; }
public Runtime.RemoteObjectUnserializableValue? UnserializableValue { get; set; }
public object Value { get; set; }
}
[JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
internal enum RemoteObjectType
{
[System.Runtime.Serialization.EnumMember(Value = "object")]Object,
[System.Runtime.Serialization.EnumMember(Value = "function")]Function,
[System.Runtime.Serialization.EnumMember(Value = "undefined")]Undefined,
[System.Runtime.Serialization.EnumMember(Value = "string")]String,
[System.Runtime.Serialization.EnumMember(Value = "number")]Number,
[System.Runtime.Serialization.EnumMember(Value = "boolean")]Boolean,
[System.Runtime.Serialization.EnumMember(Value = "symbol")]Symbol,
[System.Runtime.Serialization.EnumMember(Value = "bigint")]Bigint,
}
[JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
internal enum RemoteObjectSubtype
{
[System.Runtime.Serialization.EnumMember(Value = "array")]Array,
[System.Runtime.Serialization.EnumMember(Value = "null")]Null,
[System.Runtime.Serialization.EnumMember(Value = "node")]Node,
[System.Runtime.Serialization.EnumMember(Value = "regexp")]Regexp,
[System.Runtime.Serialization.EnumMember(Value = "date")]Date,
[System.Runtime.Serialization.EnumMember(Value = "map")]Map,
[System.Runtime.Serialization.EnumMember(Value = "set")]Set,
[System.Runtime.Serialization.EnumMember(Value = "weakmap")]Weakmap,
[System.Runtime.Serialization.EnumMember(Value = "weakset")]Weakset,
[System.Runtime.Serialization.EnumMember(Value = "error")]Error,
[System.Runtime.Serialization.EnumMember(Value = "proxy")]Proxy,
[System.Runtime.Serialization.EnumMember(Value = "promise")]Promise,
[System.Runtime.Serialization.EnumMember(Value = "typedarray")]Typedarray,
}
[JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
internal enum RemoteObjectUnserializableValue
{
[System.Runtime.Serialization.EnumMember(Value = "Infinity")]Infinity,
[System.Runtime.Serialization.EnumMember(Value = "-Infinity")]NegativeInfinity,
[System.Runtime.Serialization.EnumMember(Value = "-0")]NegativeZero,
[System.Runtime.Serialization.EnumMember(Value = "NaN")]NaN,
}
}
namespace PlaywrightSharp.Firefox.Protocol.Network
{
internal partial class HTTPHeader
{
public string Name { get; set; }
public string Value { get; set; }
}
internal partial class SecurityDetails
{
public string Protocol { get; set; }
public string SubjectName { get; set; }
public string Issuer { get; set; }
public double? ValidFrom { get; set; }
public double? ValidTo { get; set; }
}
}
namespace PlaywrightSharp.Firefox.Protocol.Accessibility
{
internal partial class AXTree
{
public string Role { get; set; }
public string Name { get; set; }
public AXTree[] Children { get; set; }
public bool? Selected { get; set; }
public bool? Focused { get; set; }
public bool? Pressed { get; set; }
public bool? Focusable { get; set; }
public bool? Haspopup { get; set; }
public bool? Required { get; set; }
public bool? Invalid { get; set; }
public bool? Modal { get; set; }
public bool? Editable { get; set; }
public bool? Busy { get; set; }
public bool? Multiline { get; set; }
public bool? Readonly { get; set; }
public Accessibility.AXTreeChecked? Checked { get; set; }
public bool? Expanded { get; set; }
public bool? Disabled { get; set; }
public bool? Multiselectable { get; set; }
public string Value { get; set; }
public string Description { get; set; }
public string Roledescription { get; set; }
public string Valuetext { get; set; }
public string Orientation { get; set; }
public string Autocomplete { get; set; }
public string Keyshortcuts { get; set; }
public double? Level { get; set; }
public string Tag { get; set; }
public bool? FoundObject { get; set; }
}
[JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
internal enum AXTreeChecked
{
[System.Runtime.Serialization.EnumMember(Value = "mixed")]Mixed,
[System.Runtime.Serialization.EnumMember(Value = "True")]True,
}
}
namespace PlaywrightSharp.Firefox.Protocol.Browser
{
internal partial class BrowserCloseRequest : IFirefoxRequest<BrowserCloseResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Browser.close";
}
internal partial class BrowserCloseResponse: IFirefoxResponse
{
}
internal partial class BrowserGetInfoRequest : IFirefoxRequest<BrowserGetInfoResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Browser.getInfo";
}
internal partial class BrowserGetInfoResponse: IFirefoxResponse
{
public string UserAgent { get; set; }
public string Version { get; set; }
}
internal partial class BrowserSetIgnoreHTTPSErrorsRequest : IFirefoxRequest<BrowserSetIgnoreHTTPSErrorsResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Browser.setIgnoreHTTPSErrors";
public bool? Enabled { get; set; }
}
internal partial class BrowserSetIgnoreHTTPSErrorsResponse: IFirefoxResponse
{
}
internal partial class BrowserGrantPermissionsRequest : IFirefoxRequest<BrowserGrantPermissionsResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Browser.grantPermissions";
public string Origin { get; set; }
public string BrowserContextId { get; set; }
public Browser.PermissionsGrantPermissions[] Permissions { get; set; }
}
internal partial class BrowserGrantPermissionsResponse: IFirefoxResponse
{
}
internal partial class BrowserResetPermissionsRequest : IFirefoxRequest<BrowserResetPermissionsResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Browser.resetPermissions";
public string BrowserContextId { get; set; }
}
internal partial class BrowserResetPermissionsResponse: IFirefoxResponse
{
}
internal partial class BrowserSetCookiesRequest : IFirefoxRequest<BrowserSetCookiesResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Browser.setCookies";
public string BrowserContextId { get; set; }
public Browser.CookieOptions[] Cookies { get; set; }
}
internal partial class BrowserSetCookiesResponse: IFirefoxResponse
{
}
internal partial class BrowserClearCookiesRequest : IFirefoxRequest<BrowserClearCookiesResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Browser.clearCookies";
public string BrowserContextId { get; set; }
}
internal partial class BrowserClearCookiesResponse: IFirefoxResponse
{
}
internal partial class BrowserGetCookiesRequest : IFirefoxRequest<BrowserGetCookiesResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Browser.getCookies";
public string BrowserContextId { get; set; }
}
internal partial class BrowserGetCookiesResponse: IFirefoxResponse
{
public Browser.Cookie[] Cookies { get; set; }
}
[JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
internal enum PermissionsGrantPermissions
{
[System.Runtime.Serialization.EnumMember(Value = "geo")]Geo,
[System.Runtime.Serialization.EnumMember(Value = "microphone")]Microphone,
[System.Runtime.Serialization.EnumMember(Value = "camera")]Camera,
[System.Runtime.Serialization.EnumMember(Value = "desktop-notifications")]DesktopNotifications,
}
}
namespace PlaywrightSharp.Firefox.Protocol.Target
{
internal partial class TargetAttachedToTargetFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Target.attachedToTarget";
public string SessionId { get; set; }
public Target.TargetInfo TargetInfo { get; set; }
}
internal partial class TargetDetachedFromTargetFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Target.detachedFromTarget";
public string SessionId { get; set; }
}
internal partial class TargetTargetCreatedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Target.targetCreated";
public Target.TargetInfoType Type { get; set; }
public string TargetId { get; set; }
public string BrowserContextId { get; set; }
public string Url { get; set; }
public string OpenerId { get; set; }
}
internal partial class TargetTargetDestroyedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Target.targetDestroyed";
public Target.TargetInfoType Type { get; set; }
public string TargetId { get; set; }
public string BrowserContextId { get; set; }
public string Url { get; set; }
public string OpenerId { get; set; }
}
internal partial class TargetTargetInfoChangedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Target.targetInfoChanged";
public Target.TargetInfoType Type { get; set; }
public string TargetId { get; set; }
public string BrowserContextId { get; set; }
public string Url { get; set; }
public string OpenerId { get; set; }
}
internal partial class TargetEnableRequest : IFirefoxRequest<TargetEnableResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Target.enable";
}
internal partial class TargetEnableResponse: IFirefoxResponse
{
}
internal partial class TargetAttachToTargetRequest : IFirefoxRequest<TargetAttachToTargetResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Target.attachToTarget";
public string TargetId { get; set; }
}
internal partial class TargetAttachToTargetResponse: IFirefoxResponse
{
public string SessionId { get; set; }
}
internal partial class TargetNewPageRequest : IFirefoxRequest<TargetNewPageResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Target.newPage";
public string BrowserContextId { get; set; }
}
internal partial class TargetNewPageResponse: IFirefoxResponse
{
public string TargetId { get; set; }
}
internal partial class TargetCreateBrowserContextRequest : IFirefoxRequest<TargetCreateBrowserContextResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Target.createBrowserContext";
}
internal partial class TargetCreateBrowserContextResponse: IFirefoxResponse
{
public string BrowserContextId { get; set; }
}
internal partial class TargetRemoveBrowserContextRequest : IFirefoxRequest<TargetRemoveBrowserContextResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Target.removeBrowserContext";
public string BrowserContextId { get; set; }
}
internal partial class TargetRemoveBrowserContextResponse: IFirefoxResponse
{
}
internal partial class TargetGetBrowserContextsRequest : IFirefoxRequest<TargetGetBrowserContextsResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Target.getBrowserContexts";
}
internal partial class TargetGetBrowserContextsResponse: IFirefoxResponse
{
public string[] BrowserContextIds { get; set; }
}
}
namespace PlaywrightSharp.Firefox.Protocol.Page
{
internal partial class PageEventFiredFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Page.eventFired";
public string FrameId { get; set; }
public Page.EventFiredName Name { get; set; }
}
internal partial class PageUncaughtErrorFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Page.uncaughtError";
public string FrameId { get; set; }
public string Message { get; set; }
public string Stack { get; set; }
}
internal partial class PageFrameAttachedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Page.frameAttached";
public string FrameId { get; set; }
public string ParentFrameId { get; set; }
}
internal partial class PageFrameDetachedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Page.frameDetached";
public string FrameId { get; set; }
}
internal partial class PageNavigationStartedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Page.navigationStarted";
public string FrameId { get; set; }
public string NavigationId { get; set; }
public string Url { get; set; }
}
internal partial class PageNavigationCommittedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Page.navigationCommitted";
public string FrameId { get; set; }
public string NavigationId { get; set; }
public string Url { get; set; }
public string Name { get; set; }
}
internal partial class PageNavigationAbortedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Page.navigationAborted";
public string FrameId { get; set; }
public string NavigationId { get; set; }
public string ErrorText { get; set; }
}
internal partial class PageSameDocumentNavigationFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Page.sameDocumentNavigation";
public string FrameId { get; set; }
public string Url { get; set; }
}
internal partial class PageDialogOpenedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Page.dialogOpened";
public string DialogId { get; set; }
public Page.DialogOpenedType Type { get; set; }
public string Message { get; set; }
public string DefaultValue { get; set; }
}
internal partial class PageDialogClosedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Page.dialogClosed";
public string DialogId { get; set; }
}
internal partial class PageBindingCalledFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Page.bindingCalled";
public string ExecutionContextId { get; set; }
public string Name { get; set; }
public object Payload { get; set; }
}
internal partial class PageFileChooserOpenedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Page.fileChooserOpened";
public string ExecutionContextId { get; set; }
public Runtime.RemoteObject Element { get; set; }
}
internal partial class PageWorkerCreatedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Page.workerCreated";
public string WorkerId { get; set; }
public string FrameId { get; set; }
public string Url { get; set; }
}
internal partial class PageWorkerDestroyedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Page.workerDestroyed";
public string WorkerId { get; set; }
}
internal partial class PageDispatchMessageFromWorkerFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Page.dispatchMessageFromWorker";
public string WorkerId { get; set; }
public string Message { get; set; }
}
internal partial class PageEnableRequest : IFirefoxRequest<PageEnableResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.enable";
}
internal partial class PageEnableResponse: IFirefoxResponse
{
}
internal partial class PageCloseRequest : IFirefoxRequest<PageCloseResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.close";
public bool? RunBeforeUnload { get; set; }
}
internal partial class PageCloseResponse: IFirefoxResponse
{
}
internal partial class PageSetFileInputFilesRequest : IFirefoxRequest<PageSetFileInputFilesResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.setFileInputFiles";
public string FrameId { get; set; }
public string ObjectId { get; set; }
public string[] Files { get; set; }
}
internal partial class PageSetFileInputFilesResponse: IFirefoxResponse
{
}
internal partial class PageAddBindingRequest : IFirefoxRequest<PageAddBindingResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.addBinding";
public string Name { get; set; }
}
internal partial class PageAddBindingResponse: IFirefoxResponse
{
}
internal partial class PageSetViewportRequest : IFirefoxRequest<PageSetViewportResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.setViewport";
public Page.Viewport Viewport { get; set; }
}
internal partial class PageSetViewportResponse: IFirefoxResponse
{
}
internal partial class PageSetUserAgentRequest : IFirefoxRequest<PageSetUserAgentResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.setUserAgent";
public string UserAgent { get; set; }
}
internal partial class PageSetUserAgentResponse: IFirefoxResponse
{
}
internal partial class PageSetEmulatedMediaRequest : IFirefoxRequest<PageSetEmulatedMediaResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.setEmulatedMedia";
public Page.SetEmulatedMediaType? Type { get; set; }
public Page.SetEmulatedMediaColorScheme? ColorScheme { get; set; }
}
internal partial class PageSetEmulatedMediaResponse: IFirefoxResponse
{
}
internal partial class PageSetBypassCSPRequest : IFirefoxRequest<PageSetBypassCSPResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.setBypassCSP";
public bool? Enabled { get; set; }
}
internal partial class PageSetBypassCSPResponse: IFirefoxResponse
{
}
internal partial class PageSetCacheDisabledRequest : IFirefoxRequest<PageSetCacheDisabledResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.setCacheDisabled";
public bool? CacheDisabled { get; set; }
}
internal partial class PageSetCacheDisabledResponse: IFirefoxResponse
{
}
internal partial class PageSetJavascriptEnabledRequest : IFirefoxRequest<PageSetJavascriptEnabledResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.setJavascriptEnabled";
public bool? Enabled { get; set; }
}
internal partial class PageSetJavascriptEnabledResponse: IFirefoxResponse
{
}
internal partial class PageDescribeNodeRequest : IFirefoxRequest<PageDescribeNodeResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.describeNode";
public string FrameId { get; set; }
public string ObjectId { get; set; }
}
internal partial class PageDescribeNodeResponse: IFirefoxResponse
{
public string ContentFrameId { get; set; }
public string OwnerFrameId { get; set; }
}
internal partial class PageAddScriptToEvaluateOnNewDocumentRequest : IFirefoxRequest<PageAddScriptToEvaluateOnNewDocumentResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.addScriptToEvaluateOnNewDocument";
public string Script { get; set; }
public string WorldName { get; set; }
}
internal partial class PageAddScriptToEvaluateOnNewDocumentResponse: IFirefoxResponse
{
public string ScriptId { get; set; }
}
internal partial class PageRemoveScriptToEvaluateOnNewDocumentRequest : IFirefoxRequest<PageRemoveScriptToEvaluateOnNewDocumentResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.removeScriptToEvaluateOnNewDocument";
public string ScriptId { get; set; }
}
internal partial class PageRemoveScriptToEvaluateOnNewDocumentResponse: IFirefoxResponse
{
}
internal partial class PageNavigateRequest : IFirefoxRequest<PageNavigateResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.navigate";
public string FrameId { get; set; }
public string Url { get; set; }
public string Referer { get; set; }
}
internal partial class PageNavigateResponse: IFirefoxResponse
{
public string NavigationId { get; set; }
public string NavigationURL { get; set; }
}
internal partial class PageGoBackRequest : IFirefoxRequest<PageGoBackResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.goBack";
public string FrameId { get; set; }
}
internal partial class PageGoBackResponse: IFirefoxResponse
{
public string NavigationId { get; set; }
public string NavigationURL { get; set; }
}
internal partial class PageGoForwardRequest : IFirefoxRequest<PageGoForwardResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.goForward";
public string FrameId { get; set; }
}
internal partial class PageGoForwardResponse: IFirefoxResponse
{
public string NavigationId { get; set; }
public string NavigationURL { get; set; }
}
internal partial class PageReloadRequest : IFirefoxRequest<PageReloadResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.reload";
public string FrameId { get; set; }
}
internal partial class PageReloadResponse: IFirefoxResponse
{
public string NavigationId { get; set; }
public string NavigationURL { get; set; }
}
internal partial class PageGetBoundingBoxRequest : IFirefoxRequest<PageGetBoundingBoxResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.getBoundingBox";
public string FrameId { get; set; }
public string ObjectId { get; set; }
}
internal partial class PageGetBoundingBoxResponse: IFirefoxResponse
{
public Page.BoundingBox BoundingBox { get; set; }
}
internal partial class PageAdoptNodeRequest : IFirefoxRequest<PageAdoptNodeResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.adoptNode";
public string FrameId { get; set; }
public string ObjectId { get; set; }
public string ExecutionContextId { get; set; }
}
internal partial class PageAdoptNodeResponse: IFirefoxResponse
{
public Runtime.RemoteObject RemoteObject { get; set; }
}
internal partial class PageScreenshotRequest : IFirefoxRequest<PageScreenshotResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.screenshot";
[JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
public Page.ScreenshotMimeType MimeType { get; set; }
public bool? FullPage { get; set; }
public Page.BoundingBox Clip { get; set; }
}
internal partial class PageScreenshotResponse: IFirefoxResponse
{
public string Data { get; set; }
}
internal partial class PageGetContentQuadsRequest : IFirefoxRequest<PageGetContentQuadsResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.getContentQuads";
public string FrameId { get; set; }
public string ObjectId { get; set; }
}
internal partial class PageGetContentQuadsResponse: IFirefoxResponse
{
public Page.DOMQuad[] Quads { get; set; }
}
internal partial class PageDispatchKeyEventRequest : IFirefoxRequest<PageDispatchKeyEventResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.dispatchKeyEvent";
public string Type { get; set; }
public string Key { get; set; }
public double? KeyCode { get; set; }
public double? Location { get; set; }
public string Code { get; set; }
public bool? Repeat { get; set; }
}
internal partial class PageDispatchKeyEventResponse: IFirefoxResponse
{
}
internal partial class PageDispatchTouchEventRequest : IFirefoxRequest<PageDispatchTouchEventResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.dispatchTouchEvent";
[JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
public Page.DispatchTouchEventType Type { get; set; }
public Page.TouchPoint[] TouchPoints { get; set; }
public double? Modifiers { get; set; }
}
internal partial class PageDispatchTouchEventResponse: IFirefoxResponse
{
public bool? DefaultPrevented { get; set; }
}
internal partial class PageDispatchMouseEventRequest : IFirefoxRequest<PageDispatchMouseEventResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.dispatchMouseEvent";
public string Type { get; set; }
public double? Button { get; set; }
public double? X { get; set; }
public double? Y { get; set; }
public double? Modifiers { get; set; }
public double? ClickCount { get; set; }
public double? Buttons { get; set; }
}
internal partial class PageDispatchMouseEventResponse: IFirefoxResponse
{
}
internal partial class PageInsertTextRequest : IFirefoxRequest<PageInsertTextResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.insertText";
public string Text { get; set; }
}
internal partial class PageInsertTextResponse: IFirefoxResponse
{
}
internal partial class PageHandleDialogRequest : IFirefoxRequest<PageHandleDialogResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.handleDialog";
public string DialogId { get; set; }
public bool? Accept { get; set; }
public string PromptText { get; set; }
}
internal partial class PageHandleDialogResponse: IFirefoxResponse
{
}
internal partial class PageSetInterceptFileChooserDialogRequest : IFirefoxRequest<PageSetInterceptFileChooserDialogResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.setInterceptFileChooserDialog";
public bool? Enabled { get; set; }
}
internal partial class PageSetInterceptFileChooserDialogResponse: IFirefoxResponse
{
}
internal partial class PageSendMessageToWorkerRequest : IFirefoxRequest<PageSendMessageToWorkerResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Page.sendMessageToWorker";
public string FrameId { get; set; }
public string WorkerId { get; set; }
public string Message { get; set; }
}
internal partial class PageSendMessageToWorkerResponse: IFirefoxResponse
{
}
[JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
internal enum EventFiredName
{
[System.Runtime.Serialization.EnumMember(Value = "load")]Load,
[System.Runtime.Serialization.EnumMember(Value = "DOMContentLoaded")]DOMContentLoaded,
}
[JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
internal enum DialogOpenedType
{
[System.Runtime.Serialization.EnumMember(Value = "prompt")]Prompt,
[System.Runtime.Serialization.EnumMember(Value = "alert")]Alert,
[System.Runtime.Serialization.EnumMember(Value = "confirm")]Confirm,
[System.Runtime.Serialization.EnumMember(Value = "beforeunload")]Beforeunload,
}
[JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
internal enum SetEmulatedMediaType
{
[System.Runtime.Serialization.EnumMember(Value = "screen")]Screen,
[System.Runtime.Serialization.EnumMember(Value = "print")]Print,
[System.Runtime.Serialization.EnumMember(Value = "")]Empty,
}
[JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
internal enum SetEmulatedMediaColorScheme
{
[System.Runtime.Serialization.EnumMember(Value = "dark")]Dark,
[System.Runtime.Serialization.EnumMember(Value = "light")]Light,
[System.Runtime.Serialization.EnumMember(Value = "no-preference")]NoPreference,
}
[JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
internal enum ScreenshotMimeType
{
[System.Runtime.Serialization.EnumMember(Value = "image/png")]ImagePng,
[System.Runtime.Serialization.EnumMember(Value = "image/jpeg")]ImageJpeg,
}
[JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
internal enum DispatchTouchEventType
{
[System.Runtime.Serialization.EnumMember(Value = "touchStart")]TouchStart,
[System.Runtime.Serialization.EnumMember(Value = "touchEnd")]TouchEnd,
[System.Runtime.Serialization.EnumMember(Value = "touchMove")]TouchMove,
[System.Runtime.Serialization.EnumMember(Value = "touchCancel")]TouchCancel,
}
}
namespace PlaywrightSharp.Firefox.Protocol.Runtime
{
internal partial class RuntimeExecutionContextCreatedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Runtime.executionContextCreated";
public string ExecutionContextId { get; set; }
public object AuxData { get; set; }
}
internal partial class RuntimeExecutionContextDestroyedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Runtime.executionContextDestroyed";
public string ExecutionContextId { get; set; }
}
internal partial class RuntimeConsoleFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Runtime.console";
public string ExecutionContextId { get; set; }
public Runtime.RemoteObject[] Args { get; set; }
public string Type { get; set; }
public Runtime.ScriptLocation Location { get; set; }
}
internal partial class RuntimeEnableRequest : IFirefoxRequest<RuntimeEnableResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Runtime.enable";
}
internal partial class RuntimeEnableResponse: IFirefoxResponse
{
}
internal partial class RuntimeEvaluateRequest : IFirefoxRequest<RuntimeEvaluateResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Runtime.evaluate";
public string ExecutionContextId { get; set; }
public string Expression { get; set; }
public bool? ReturnByValue { get; set; }
}
internal partial class RuntimeEvaluateResponse: IFirefoxResponse
{
public Runtime.RemoteObject Result { get; set; }
public Runtime.ExceptionDetails ExceptionDetails { get; set; }
}
internal partial class RuntimeCallFunctionRequest : IFirefoxRequest<RuntimeCallFunctionResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Runtime.callFunction";
public string ExecutionContextId { get; set; }
public string FunctionDeclaration { get; set; }
public bool? ReturnByValue { get; set; }
public Runtime.CallFunctionArgument[] Args { get; set; }
}
internal partial class RuntimeCallFunctionResponse: IFirefoxResponse
{
public Runtime.RemoteObject Result { get; set; }
public Runtime.ExceptionDetails ExceptionDetails { get; set; }
}
internal partial class RuntimeDisposeObjectRequest : IFirefoxRequest<RuntimeDisposeObjectResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Runtime.disposeObject";
public string ExecutionContextId { get; set; }
public string ObjectId { get; set; }
}
internal partial class RuntimeDisposeObjectResponse: IFirefoxResponse
{
}
internal partial class RuntimeGetObjectPropertiesRequest : IFirefoxRequest<RuntimeGetObjectPropertiesResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Runtime.getObjectProperties";
public string ExecutionContextId { get; set; }
public string ObjectId { get; set; }
}
internal partial class RuntimeGetObjectPropertiesResponse: IFirefoxResponse
{
public Runtime.ObjectProperty[] Properties { get; set; }
}
}
namespace PlaywrightSharp.Firefox.Protocol.Network
{
internal partial class NetworkRequestWillBeSentFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Network.requestWillBeSent";
public string FrameId { get; set; }
public string RequestId { get; set; }
public string RedirectedFrom { get; set; }
public string PostData { get; set; }
public Network.HTTPHeader[] Headers { get; set; }
public bool? IsIntercepted { get; set; }
public string Url { get; set; }
public string Method { get; set; }
public string NavigationId { get; set; }
public string Cause { get; set; }
}
internal partial class NetworkResponseReceivedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Network.responseReceived";
public Network.SecurityDetails SecurityDetails { get; set; }
public string RequestId { get; set; }
public bool? FromCache { get; set; }
public string RemoteIPAddress { get; set; }
public double? RemotePort { get; set; }
public double? Status { get; set; }
public string StatusText { get; set; }
public Network.HTTPHeader[] Headers { get; set; }
}
internal partial class NetworkRequestFinishedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Network.requestFinished";
public string RequestId { get; set; }
}
internal partial class NetworkRequestFailedFirefoxEvent : IFirefoxEvent
{
public string InternalName { get; } = "Network.requestFailed";
public string RequestId { get; set; }
public string ErrorCode { get; set; }
}
internal partial class NetworkEnableRequest : IFirefoxRequest<NetworkEnableResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Network.enable";
}
internal partial class NetworkEnableResponse: IFirefoxResponse
{
}
internal partial class NetworkSetRequestInterceptionRequest : IFirefoxRequest<NetworkSetRequestInterceptionResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Network.setRequestInterception";
public bool? Enabled { get; set; }
}
internal partial class NetworkSetRequestInterceptionResponse: IFirefoxResponse
{
}
internal partial class NetworkSetExtraHTTPHeadersRequest : IFirefoxRequest<NetworkSetExtraHTTPHeadersResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Network.setExtraHTTPHeaders";
public Network.HTTPHeader[] Headers { get; set; }
}
internal partial class NetworkSetExtraHTTPHeadersResponse: IFirefoxResponse
{
}
internal partial class NetworkAbortInterceptedRequestRequest : IFirefoxRequest<NetworkAbortInterceptedRequestResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Network.abortInterceptedRequest";
public string RequestId { get; set; }
public string ErrorCode { get; set; }
}
internal partial class NetworkAbortInterceptedRequestResponse: IFirefoxResponse
{
}
internal partial class NetworkResumeInterceptedRequestRequest : IFirefoxRequest<NetworkResumeInterceptedRequestResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Network.resumeInterceptedRequest";
public string RequestId { get; set; }
public string Method { get; set; }
public Network.HTTPHeader[] Headers { get; set; }
public string PostData { get; set; }
}
internal partial class NetworkResumeInterceptedRequestResponse: IFirefoxResponse
{
}
internal partial class NetworkFulfillInterceptedRequestRequest : IFirefoxRequest<NetworkFulfillInterceptedRequestResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Network.fulfillInterceptedRequest";
public string RequestId { get; set; }
public double? Status { get; set; }
public string StatusText { get; set; }
public Network.HTTPHeader[] Headers { get; set; }
public string Base64Body { get; set; }
}
internal partial class NetworkFulfillInterceptedRequestResponse: IFirefoxResponse
{
}
internal partial class NetworkGetResponseBodyRequest : IFirefoxRequest<NetworkGetResponseBodyResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Network.getResponseBody";
public string RequestId { get; set; }
}
internal partial class NetworkGetResponseBodyResponse: IFirefoxResponse
{
public string Base64Body { get; set; }
public bool? Evicted { get; set; }
}
internal partial class NetworkSetAuthCredentialsRequest : IFirefoxRequest<NetworkSetAuthCredentialsResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Network.setAuthCredentials";
public string Username { get; set; }
public string Password { get; set; }
}
internal partial class NetworkSetAuthCredentialsResponse: IFirefoxResponse
{
}
}
namespace PlaywrightSharp.Firefox.Protocol.Accessibility
{
internal partial class AccessibilityGetFullAXTreeRequest : IFirefoxRequest<AccessibilityGetFullAXTreeResponse>
{
[System.Text.Json.Serialization.JsonIgnore]
public string Command { get; } = "Accessibility.getFullAXTree";
public string ObjectId { get; set; }
}
internal partial class AccessibilityGetFullAXTreeResponse: IFirefoxResponse
{
public Accessibility.AXTree Tree { get; set; }
}
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

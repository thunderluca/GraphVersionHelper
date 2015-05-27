# GraphVersionHelper

A light .NET helper to determine which are currently versions of [Facebook Graph API](https://developers.facebook.com/docs/graph-api/using-graph-api/) for HTTP request without update your applications every time a new version is available.


## Supported platforms
- .NET Framework 4.5;
- Silverlight 5;
- Windows 8;
- Windows Phone 8.1;
- Windows Phone Silverlight 8;
- Xamarin.Android;
- Xamarin.iOS;
- Xamarin.iOS (Classic).


## Dependencies
- Microsoft.Net.Http;
- Microsoft.Bcl;
- Microsoft.Bcl.Build;
- Microsoft.Bcl.Async.

##Documentation
Just use the following line

```
var item = await VersionHelper.GetLatestVersionAsync();
```

to retrieve a GraphItem which contains latest version and a collection of previous working versions of Graph API.

## Installation
Simply build this solution or use the [Nuget package](https://www.nuget.org/packages/GraphVersionHelper/)!

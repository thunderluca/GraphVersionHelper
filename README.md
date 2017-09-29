# GraphVersionHelper

A light .NET helper to determine which are currently versions of [Facebook Graph API](https://developers.facebook.com/docs/graph-api/using-graph-api/) for HTTP request without update your applications every time a new version is available.


## Supported framework
- .NET Standard 1.1

## Documentation
Just use the following line

```
var item = await VersionHelper.GetLatestVersionAsync();
```

to retrieve a GraphItem which contains latest version and a collection of previous working versions of Graph API.

## Installation
Simply build this solution or use the [Nuget package](https://www.nuget.org/packages/GraphVersionHelper/)!

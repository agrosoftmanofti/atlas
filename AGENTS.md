# Contributor Guidelines

This repository uses .NET 9 and provides a lightweight integration layer for ABP Framework. The Blazor core projects must remain free of direct references to ABP packages.

## Building the Solution
1. Install the .NET SDK 9.0. You can run `./utility/install-dotnet-sdk.sh` on Debian/Ubuntu systems.
2. Alternatively, open the project in a Dev Container which already includes the SDK (`.devcontainer` folder).
3. After installing the SDK run:

```bash
dotnet build Atlas.Blazor.sln
```

To verify formatting use:

```bash
dotnet format --verify-no-changes
```

## Development Notes
- All ABP related services live under `src/Atlas.Integration.ABP`.
- Use `BearerTokenHandler` and `ITokenProvider` abstractions for authenticated HTTP calls.


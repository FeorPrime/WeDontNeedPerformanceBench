## Disclamer
This is a template for performance tests. It was created to decide which laptop is best suited for development tasks. No GPU tests or network I/O tests (only if you are targeting an SMB\NFS share during the I/O test).

`Evrything goes as is with no warriancy.`

### How to run

You need to run the release config). As simple as that:

```` shell
    dotnet run -p WeDontNeedPerfomanceBench.csproj -c Release
````

Don't forget to provide params, or default will be used:


# DemoAppWithLibrary

A demo app with a library that it depends on.

To restore packages, run ```$ dotnet restore``` at the root level (you can also do this at each project level).

To build and run:

```
$ cd ConsoleApp
$ dotnet build
$ ./bin/Debug/netstandardapp1.5/{os_identifier}/Console App "Your Name here"
```

And that it's it!

To build as release:

```
$ dotnet build -c release
```

To package up the library as a `nupkg`:

```
$ dotnet pack -c release
```

You can view the package as such:

```
$ ls bin/release
```

# Nothing

[![Nuget](https://img.shields.io/nuget/v/Dev.ComradeVanti.Nothing)](https://www.nuget.org/packages/Dev.ComradeVanti.Nothing)

Nothing is a type representing the absence of data, similarly to `Unit` in
[F#](https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/unit-type).
Use it as a return value from methods where you would traditionally return `void`.

## Usage

`Nothing` exposes a single static readonly instance called `Nothing.atAll`. This
instance is equal to itself using both `==` and `Equals`.

The package also includes a few useful extension methods which are listed below.

- Convert a `Task` to a `Task<Nothing>` using the `ToNothingTask` method
- Convert a `Action` to a `Func<Nothing>` using the `ToNothingFunc` method.
  Works with up to 3 parameters
- Convert anything to `Nothing` with the `Discard` method
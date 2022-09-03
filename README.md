# Nothing

## Usage

`Nothing` exposes a single static readonly instance called `Nothing.atAll`. This
instance is equal to itself using both `==` and `Equals`.

The package also includes a few useful extension methods which are listed below.

- Convert a `Task` to a `Task<Nothing>` using the `ToNothingTask` method
- Convert a `Action` to a `Func<Nothing>` using the `ToNothingFunc` method.
  Works with up to 3 parameters
- Convert anything to `Nothing` with the `Discard` method
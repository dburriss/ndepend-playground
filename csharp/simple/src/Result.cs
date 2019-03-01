namespace simple
{
    public class Result
    {
        public bool IsSuccess { get; private set; }

        private Result(bool successful)
        {
            IsSuccess = successful;
        }

        public static Result Success => new Result(true);
        public static Result Failure => new Result(false);
    }

    public class Result<T>
    {
        public bool IsSuccess { get; private set; }
        public T Value { get; private set; }

        private Result(T value, bool successful)
        {
            Value = value;
            IsSuccess = successful;
        }

        public static Result<T> Success(T value) => new Result<T>(value, true);
        public static Result<T> Failure() => new Result<T>(default(T), false);
        public static Result<T> Failure(T defaultValue) => new Result<T>(defaultValue, false);
    }
}

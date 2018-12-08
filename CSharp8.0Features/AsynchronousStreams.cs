using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8._0Features
{
    class AsynchronousStreams
    {
        internal static async Task Example()
        {
            await foreach(var fruit in GetFruitsAsync())
            {
                Console.WriteLine(fruit);
            }
        }

        private static async IAsyncEnumerable<object> GetFruitsAsync()
        {
            string[] fruits = { "Apple", "Banana", "Orange", "Mango" };
            foreach(var fruit in fruits)
            {
                await Task.Delay(1000);
                yield return fruit;
            }
        }
    }
}

namespace System.Threading.Tasks
{
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks.Sources;

    internal struct ManualResetValueTaskSourceLogic<TResult>
    {
        private ManualResetValueTaskSourceCore<TResult> _core;
        public ManualResetValueTaskSourceLogic(IStrongBox<ManualResetValueTaskSourceLogic<TResult>> parent) : this() { }
        public short Version => _core.Version;
        public TResult GetResult(short token) => _core.GetResult(token);
        public ValueTaskSourceStatus GetStatus(short token) => _core.GetStatus(token);
        public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags) => _core.OnCompleted(continuation, state, token, flags);
        public void Reset() => _core.Reset();
        public void SetResult(TResult result) => _core.SetResult(result);
        public void SetException(Exception error) => _core.SetException(error);
    }
}

namespace System.Runtime.CompilerServices
{
    internal interface IStrongBox<T> { ref T Value { get; } }
}
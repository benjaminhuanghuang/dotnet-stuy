
ThreadPool中有若干数量的线程，如果有任务需要处理时，会从线程池中获取一个空闲的线程来执行任务，任务执行完毕后线程不会销毁，而是被线程池回收以供后续任务使用。
当线程池中所有的线程都在忙碌时，又有新任务要处理时，线程池才会新建一个线程来处理该任务，如果线程数量达到设置的最大值，任务会排队，等待其他任务释放线程后再执行

ThreadTool Sample
```
static void Main(string[] args)
{
    for (int i = 1; i <=10; i++)
    {
        //ThreadPool执行任务
        ThreadPool.QueueUserWorkItem(new WaitCallback((obj) => {
            Console.WriteLine($"第{obj}个执行任务");
        }), i);
    }
    Console.ReadKey();
}

```
但是ThreadPool不能控制线程的执行顺序，我们也不能获取线程池内线程取消/异常/完成的通知，即我们不能有效监控和控制线程池中的线程。

using System;

class MemoryMeasurer
{
    long[] envs = new long[3];
    long[] gcs = new long[3];

    public void Start()
    {
        SetMemory(ref envs[0], ref gcs[0]);
    }
    public void Stop()
    {
        SetMemory(ref envs[1], ref gcs[1]);
    }
    public void Show()
    {
        CalcDiff();
        Console.WriteLine("方法|差分|終了|開始");
        Console.WriteLine("----|----|----|----");
        Console.WriteLine($"Env|{envs[2]}|{envs[1]}|{envs[0]}");
        Console.WriteLine($"GC |{gcs[2]}|{gcs[1]}|{gcs[0]}");
    }
    private void SetMemory(ref long env, ref long gc)
    {
        env = Environment.WorkingSet;
        gc = GC.GetTotalMemory(true);
    }
    private void CalcDiff()
    {
        envs[2] = envs[1] - envs[0];
        gcs[2] = gcs[1] - gcs[0];
    }
}

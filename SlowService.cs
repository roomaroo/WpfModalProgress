using System;
using System.Threading.Tasks;

namespace ModalProgress
{
    public class SlowService
    {
        public async Task DoStuff(IProgress progress)
        {
            progress.Progress = 0;
            progress.Message = "Starting";

            for (var i = 0; i < 10; i++)
            {
                await Task.Delay(TimeSpan.FromSeconds(1.0)).ConfigureAwait(false);
                progress.Progress = i * 100 / 10;
                progress.Message = $"Step {i} of 10";
            }
        }
    }
}

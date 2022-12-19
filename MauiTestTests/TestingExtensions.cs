using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace MauiTestTests
{
    public static class TestingExtensions
    {
        public static async Task ExecuteUntilComplete(this ICommand command, object? parameter = null)
        {
            if (command is IAsyncRelayCommand arc)
            {
                await arc.ExecuteAsync(parameter);
                return;
            }

            command.Execute(parameter);
        }
    }
}

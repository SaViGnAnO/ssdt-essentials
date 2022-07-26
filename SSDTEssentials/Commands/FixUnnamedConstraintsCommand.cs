namespace SSDTEssentials
{
    [Command(PackageIds.FixUnnamedConstraintsCommand)]
    internal sealed class FixUnnamedConstraintsCommand : BaseCommand<FixUnnamedConstraintsCommand>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            await VS.MessageBox.ShowWarningAsync("SSDTEssentials", "Button clicked");
        }
    }
}

using Microsoft.AspNetCore.SignalR;

namespace SignalR.Hubs;

public class UserHub : Hub
{
    // Counts the total views that a Web page has
    public int TotalViews { get; set; } = 0;

    /// <summary>
    /// Increments the TotalViews variable.
    /// </summary>
    /// <returns>Task.</returns>
    public async Task NewWindowLoaded()
    {
        TotalViews++;

        // sends update to all clients that total views have been updated
        await Clients.All.SendAsync("updateTotalViews", TotalViews);
    }


}

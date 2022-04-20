using System.Drawing;
using System.Windows.Forms;

namespace PerDiemUI
{
    public static class StatusBarMessage
    {
        private static void Message(this ToolStripStatusLabel statusBarLabel, string message, Color color)
        {
            statusBarLabel.ForeColor = color;
            statusBarLabel.Text = message;
        }

        public static void MessageReady(this ToolStripStatusLabel statusBarLabel)
        {
            Message(statusBarLabel, "Ready.", Color.Black);
        }

        public static void MessageDone(this ToolStripStatusLabel statusBarLabel)
        {
            Message(statusBarLabel, "Done!.", Color.Green);
        }

        public static void MessageExchangeRateWrongFormat(this ToolStripStatusLabel statusBarLabel)
        {
            Message(statusBarLabel, "Exchange Rate: Wrong format!", Color.Red);
        }

        public static void MessageAdvanePaymentWrongFormat(this ToolStripStatusLabel statusBarLabel)
        {
            Message(statusBarLabel, "Advance Payment: Wrong format!", Color.Red);
        }

        public static void MessageTripDurationHasToBePositive(this ToolStripStatusLabel statusBarLabel)
        {
            Message(statusBarLabel, "Trip duration has to be positive!", Color.Red);
        }
    }
}
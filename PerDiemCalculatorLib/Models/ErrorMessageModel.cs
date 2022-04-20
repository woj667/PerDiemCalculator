namespace PerDiemCalculatorLib.Models
{
    /// <summary>
    /// Model that stores error's header and its explanation.
    /// </summary>
    /// <param name="Caption"></param>
    /// <param name="Text"></param>
    public record struct ErrorMessageModel(string Caption, string Text);
}
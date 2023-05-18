namespace Triangular.BLL
{
    public interface IGridReference
    {
        char Row { get; set; }
        int Column { get; set; }

        int GetNumericRow();
    }
}
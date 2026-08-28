namespace ConferenceRoomBooking.Models;

/// <summary>
/// Бронювання конкретного залу на певний проміжок часу.
/// Зберігає обрані послуги та розраховану вартість.
/// </summary>
public sealed class Booking
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid RoomId { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public List<AdditionalService> SelectedServices { get; set; } = [];

    public decimal RoomRentalPrice { get; set; }

    public decimal ServicesPrice { get; set; }

    public decimal TotalPrice { get; set; }
}

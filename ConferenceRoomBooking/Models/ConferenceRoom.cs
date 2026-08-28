namespace ConferenceRoomBooking.Models;

/// <summary>
/// Конференц-зал, який можна знайти та забронювати.
/// Містить базову ціну за годину та список доступних послуг.
/// </summary>
public sealed class ConferenceRoom
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public required string Name { get; set; }

    public int Capacity { get; set; }

    public decimal BaseHourlyRate { get; set; }

    public List<AdditionalService> AvailableServices { get; set; } = [];
}

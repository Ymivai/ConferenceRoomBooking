namespace ConferenceRoomBooking.Models;

/// <summary>
/// Додаткова послуга, яку можна замовити разом із конференц-залом.
/// Наприклад: проєктор, Wi-Fi або звук.
/// </summary>
public sealed class AdditionalService
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public required string Name { get; set; }

    public decimal Price { get; set; }
}

namespace ConferenceRoomBooking.DTOs;

/// <summary>
/// Дані конференц-залу, які API повертає клієнту.
/// </summary>
public sealed record RoomResponse(
    Guid Id,
    string Name,
    int Capacity,
    decimal BaseHourlyRate,
    IReadOnlyCollection<AdditionalServiceDto> AvailableServices);

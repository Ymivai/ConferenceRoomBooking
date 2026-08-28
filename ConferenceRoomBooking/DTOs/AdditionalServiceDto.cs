namespace ConferenceRoomBooking.DTOs;

/// <summary>
/// Дані послуги, які API повертає клієнту.
/// </summary>
public sealed record AdditionalServiceDto(
    Guid Id,
    string Name,
    decimal Price);

namespace ConferenceRoomBooking.DTOs;

/// <summary>
/// Результат створення або отримання бронювання.
/// </summary>
public sealed record BookingResponse(
    Guid Id,
    Guid RoomId,
    string RoomName,
    DateTime StartTime,
    DateTime EndTime,
    int DurationHours,
    IReadOnlyCollection<AdditionalServiceDto> SelectedServices,
    decimal RoomRentalPrice,
    decimal ServicesPrice,
    decimal TotalPrice);

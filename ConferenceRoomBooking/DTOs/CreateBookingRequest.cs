using System.ComponentModel.DataAnnotations;

namespace ConferenceRoomBooking.DTOs;

/// <summary>
/// Запит на створення бронювання конференц-залу.
/// </summary>
public sealed record CreateBookingRequest(
    [Required] Guid RoomId,
    [Required] DateTime StartTime,
    [Required] int DurationHours,
    IReadOnlyCollection<Guid> SelectedServiceIds);

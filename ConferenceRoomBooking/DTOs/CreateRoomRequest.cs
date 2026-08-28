using System.ComponentModel.DataAnnotations;

namespace ConferenceRoomBooking.DTOs;

/// <summary>
/// Запит на створення нового конференц-залу.
/// </summary>
public sealed record CreateRoomRequest(
    [Required, MinLength(2), MaxLength(120)] string Name,
    [Range(1, 10_000)] int Capacity,
    [Range(0.01, 1_000_000)] decimal BaseHourlyRate,
    IReadOnlyCollection<CreateAdditionalServiceRequest> AvailableServices);

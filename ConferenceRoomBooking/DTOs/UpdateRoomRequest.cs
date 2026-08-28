using System.ComponentModel.DataAnnotations;

namespace ConferenceRoomBooking.DTOs;

/// <summary>
/// Запит на оновлення інформації про конференц-зал.
/// </summary>
public sealed record UpdateRoomRequest(
    [Required, MinLength(2), MaxLength(120)] string Name,
    [Range(1, 10_000)] int Capacity,
    [Range(0.01, 1_000_000)] decimal BaseHourlyRate,
    IReadOnlyCollection<CreateAdditionalServiceRequest> AvailableServices);

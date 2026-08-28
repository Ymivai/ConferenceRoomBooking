using System.ComponentModel.DataAnnotations;

namespace ConferenceRoomBooking.DTOs;

/// <summary>
/// Дані для додавання послуги до конференц-залу.
/// </summary>
public sealed record CreateAdditionalServiceRequest(
    [Required, MinLength(2), MaxLength(80)] string Name,
    [Range(0.01, 1_000_000)] decimal Price);

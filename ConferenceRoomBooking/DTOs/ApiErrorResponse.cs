namespace ConferenceRoomBooking.DTOs;

/// <summary>
/// Єдиний формат простої помилки API.
/// </summary>
public sealed record ApiErrorResponse(string Message);

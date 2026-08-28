namespace ConferenceRoomBooking.DTOs;

/// <summary>
/// Загальний звіт для бізнес-аналітики.
/// </summary>
public sealed record ReportSummaryResponse(
    int TotalBookings,
    decimal TotalRevenue,
    string? MostPopularRoom,
    IReadOnlyCollection<RoomRevenueResponse> RevenueByRoom,
    IReadOnlyCollection<ServiceUsageResponse> PopularServices);

public sealed record RoomRevenueResponse(
    Guid RoomId,
    string RoomName,
    int BookingsCount,
    decimal Revenue);

public sealed record ServiceUsageResponse(
    Guid ServiceId,
    string ServiceName,
    int UsageCount,
    decimal Revenue);

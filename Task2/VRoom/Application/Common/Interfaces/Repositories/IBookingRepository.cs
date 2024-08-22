namespace Application.Common.Interfaces.Repositories;

public interface IBookingRepository
{
    public Task<BookingGotDto> Create(CreateBookingDto createBookingDto);
    
    public Task<List<BookingGotDto>> GetAll();
}
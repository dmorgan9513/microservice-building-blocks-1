

namespace ConferenceRegistrationApi.Controllers;

public class ConferenceRegistrationsController : ControllerBase
{
    private readonly IProcessReservations _reservationProcessor;

    public ConferenceRegistrationsController(IProcessReservations reservationProcessor)
    {
        _reservationProcessor = reservationProcessor;
    }

    [HttpPost("conference-registrations")]
    public async Task<ActionResult> AddRegistration([FromBody] ConferenceRegistration request)
    {
        // Validate the the thing.
        // Write the Code I wish I Had
        ConferenceConfirmation response = await _reservationProcessor.ProcessReservationAsync(request);
        return StatusCode(201, request);
    }
}





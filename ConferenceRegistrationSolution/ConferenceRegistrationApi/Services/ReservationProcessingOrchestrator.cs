namespace ConferenceRegistrationApi.Services;

public class ReservationProcessingOrchestrator : IProcessReservations
{
    public Task<ConferenceConfirmation> ProcessReservationAsync(ConferenceRegistration request)
    {
        // "Transaction List"
        // - I have the id, but is that a real conference? has it already happened? is it full? THE NAME
        // - Is this a real user? Are they allowed to attend conferences, all that jazz... and WHAT IS THERE NAME AND EMAIL ADDRESS?
        // - if the above two are true, charge their credit card.
        // - if that worked, then register them for the conference.
        // - what else? Send a confirmation email? blah blah blah blah
        
    }
}

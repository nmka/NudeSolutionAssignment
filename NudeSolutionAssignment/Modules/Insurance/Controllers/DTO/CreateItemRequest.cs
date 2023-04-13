namespace NudeSolutionAssignment.Modules.Insurance.Controllers.DTO
{
    public record CreateItemRequest(
        string Name,
        int CategoryId,
        float Value
    );
}

namespace NudeSolutionAssignment.Controllers.Contracts
{
    public record CreateItemRequest(
        string name,
        int categoryId,
        float value
    );
}
